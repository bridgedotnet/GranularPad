using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class OthersSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Others", new[]
            {
                new SnippetViewModel("Shapes", "pack://application:,,,/GranularPad;component/Snippets/Shapes.xaml"),
                new SnippetViewModel("GradientBrush", "pack://application:,,,/GranularPad;component/Snippets/Media.GradientBrush.xaml"),
            });
        }
    }
}
