namespace Gestures;

public partial class MainPage : ContentPage
{
    int count = 0;
    int pointerCount = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTapGestureRecognizerTapped(
        object sender,
        TappedEventArgs args
    )
    {
        count++;

        if (count == 1)
            CounterLabel.Text = $"Clicked {count} time";
        else
            CounterLabel.Text = $"Clicked {count} times";
    }

    private void OnPointerEntered(
        object sender,
        PointerEventArgs e
    )
    {
        pointerCount++;
        if (pointerCount == 1)
            CounterLabel.Text =
                $"Pointer entered {pointerCount} time";
        else
            CounterLabel.Text =
                $"Pointer entered {pointerCount} times";
    }
}
