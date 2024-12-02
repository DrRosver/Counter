namespace Counter.Views;

public partial class MainPage : ContentPage
{
    private int _counter = 0;

    public MainPage()
    {
        InitializeComponent();
    }


    private void OnIncrementClicked(object sender, EventArgs e)
    {
        _counter++; 
        CounterLabel.Text = _counter.ToString(); 
    }

    private void OnDecrementClicked(object sender, EventArgs e)
    {
        _counter--; 
        CounterLabel.Text = _counter.ToString(); 
    }
}
