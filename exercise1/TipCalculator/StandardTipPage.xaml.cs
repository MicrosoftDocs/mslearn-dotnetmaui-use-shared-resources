namespace TipCalculator;

public partial class StandardTipPage : ContentPage
{
    private Color colorNavy = Colors.Navy;
    private Color colorSilver = Colors.Silver;

    public StandardTipPage()
    {
        InitializeComponent();
        billInput.TextChanged += (s, e) => CalculateTip();
    }

    void CalculateTip()
    {
        double bill;

        if (Double.TryParse(billInput.Text, out bill) && bill > 0)
        {
            double tip = Math.Round(bill * 0.15, 2);
            double final = bill + tip;

            tipOutput.Text = tip.ToString("C");
            totalOutput.Text = final.ToString("C");
        }
    }

    void OnLight(object sender, EventArgs e)
    {
        LayoutRoot.BackgroundColor = colorSilver;

        tipLabel.TextColor = colorNavy;
        billLabel.TextColor = colorNavy;
        totalLabel.TextColor = colorNavy;
        tipOutput.TextColor = colorNavy;
        totalOutput.TextColor = colorNavy;
    }

    void OnDark(object sender, EventArgs e)
    {
        LayoutRoot.BackgroundColor = colorNavy;

        tipLabel.TextColor = colorSilver;
        billLabel.TextColor = colorSilver;
        totalLabel.TextColor = colorSilver;
        tipOutput.TextColor = colorSilver;
        totalOutput.TextColor = colorSilver;
    }

    async void GotoCustom(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CustomTipPage));
    }
}