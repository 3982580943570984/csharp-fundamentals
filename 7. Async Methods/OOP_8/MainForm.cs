namespace Studying;

public partial class MainForm : Form
{
    public MainForm() => InitializeComponent();

    private async void ButtonGetMax_Click(object sender, EventArgs e)
    {
        int max = await VectorHelper.FindMaxAsync(VectorHelper.GenerateVector());
        labelMaxVectorValue.Text = $"Максимальное значение в векторе: {max}";
    }

    private async void ButtonGetTime_Click(object sender, EventArgs e)
    {
        DateTime now = await TimeHelper.GetSystemTimeAsync();
        labelDateTime.Text = $"Системное время: {now}";
    }

    private async void ButtonGetQuote_Click(object sender, EventArgs e)
    {
        string quote = await QuoteHelper.GetQuoteAsync();
        labelQuote.Text = quote;
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}

