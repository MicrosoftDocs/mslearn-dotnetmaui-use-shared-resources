namespace TipCalculator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(CustomTipPage), typeof(CustomTipPage));
    }
}
