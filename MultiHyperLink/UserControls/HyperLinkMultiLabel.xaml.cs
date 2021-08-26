using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace MultiHyperLink.UserControls
{
    /// <summary>
    /// HyperLinkMultiLabel.xaml の相互作用ロジック
    /// </summary>
    public partial class HyperLinkMultiLabel : UserControl
    {
        public HyperLinkMultiLabel()
        {

        }

        public HyperLinkMultiLabel(Dictionary<string, string> TextToLink)
        {
            InitializeComponent();

            foreach (string text in TextToLink.Keys)
            {
                Label label = new Label()
                {
                    Background = Brushes.Transparent,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center
                };
                Hyperlink link = new Hyperlink();
                link.Inlines.Add(text);
                link.NavigateUri = new Uri(TextToLink[text]);
                link.RequestNavigate += Link_RequestNavigate;
                label.Content = link;
                LabelPanel.Children.Add(label);
            }
        }

        private void Link_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.LocalPath));
            e.Handled = true;
        }
    }
}
