using OurApp.Services;

namespace OurApp.Views;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
        HistoryCollectionView.ItemsSource = MovieManager.History;
        UpdateUI();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UpdateUI();
    }

    private void UpdateUI()
    {
        HistoryCountLabel.Text = $"Просмотрено: {MovieManager.History.Count}";
        ClearHistoryButton.IsVisible = MovieManager.History.Count > 0;
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnClearHistoryClicked(object sender, EventArgs e)
    {
        MovieManager.History.Clear();
        UpdateUI();
    }
}