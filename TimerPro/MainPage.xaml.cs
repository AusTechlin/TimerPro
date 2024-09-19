using Microsoft.Maui.Layouts;
using TimerPro.Custom;

namespace TimerPro;

public partial class MainPage : ContentPage
{
    private TimerLogic oTimerLogic = new TimerLogic();

    public MainPage()
    {
        InitializeComponent();
        Title = "TimerPro";
    }

    private void Start_OnClicked(object sender, EventArgs e)
    {
        btnStart.IsEnabled = false;
        btnStop.IsEnabled = true;
                
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (btnStop.IsEnabled)
            {
                oTimerLogic.SetTickCount();
                lblDisplay.Text = oTimerLogic.GetFormatedString();
            }
            return btnStop.IsEnabled;
        });
    }

    private void Stop_OnClicked(object sender, EventArgs e)
    {
        btnStop.IsEnabled = false;
        btnStart.IsEnabled = true;
    }

    private void Reset_OnClicked(object sender, EventArgs e)
    {
        oTimerLogic.Reset();
        lblDisplay.Text = oTimerLogic.GetFormatedString();
    }
}