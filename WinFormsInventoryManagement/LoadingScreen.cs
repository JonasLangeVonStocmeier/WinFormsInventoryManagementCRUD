namespace WinFormsInventoryManagement;

public partial class LoadingScreen : Form
{
    private int loadingbarValue = 0;
    public LoadingScreen()
    {
        InitializeComponent();
    }
    private void LoadingScreen_Load(object sender, EventArgs e)
    {
        loadingbarTimer.Start();
    }

    private void LoadingbarTimer_Tick(object sender, EventArgs e)
    {
        loadingbarValue += 2;

        lblLoadingProgress.Text = loadingbarValue.ToString() + "%";
        loadingProgressbar.Value = loadingbarValue;

        if (loadingbarValue >= loadingProgressbar.Maximum)
        {
            loadingbarTimer.Stop();
        }


    }


}
