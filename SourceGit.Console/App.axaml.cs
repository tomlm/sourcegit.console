using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SourceGit;

namespace SourceGit.Console
{
    public partial class App : SourceGit.App
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }


    }
}
