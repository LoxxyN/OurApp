using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using OurApp.Services;

namespace OurApp.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly Random _random = new();

        public MainPage()
        {
            InitializeComponent();
            MoviesCollectionView.ItemsSource = MovieManager.Movies;
            UpdateUI();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdateUI();
            MovieEntry?.Focus();
        }

        private void UpdateUI()
        {
            MoviesCountLabel.Text = $"Всего фильмов: {MovieManager.Movies.Count}";
            ClearListButton.IsVisible = MovieManager.Movies.Count > 0;
        }

        private void OnAddMovieClicked(object sender, EventArgs e) => AddMovie();
        private void OnMovieEntryCompleted(object sender, EventArgs e) => AddMovie();

        private void AddMovie()
        {
            var name = MovieEntry.Text?.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                MovieManager.Movies.Add(name);
                MovieEntry.Text = string.Empty;
                UpdateUI();
            }
        }

        private void OnDeleteMovieClicked(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.BindingContext is string movie)
            {
                MovieManager.Movies.Remove(movie);
                UpdateUI();
            }
        }

        private void OnMarkWatchedClicked(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.BindingContext is string movie)
            {
                MovieManager.Movies.Remove(movie);
                UpdateUI();
            }
        }

        private void OnClearListClicked(object sender, EventArgs e)
        {
            MovieManager.Movies.Clear();
            ResultFrame.IsVisible = false;
            UpdateUI();
        }

        private async void OnSpinClicked(object sender, EventArgs e)
        {
            if (MovieManager.Movies.Count == 0)
            {
                await DisplayAlert("Внимание", "Сначала добавьте фильмы в список!", "ОК");
                return;
            }

            SpinButton.IsEnabled = false;
            ResultFrame.IsVisible = true;

            for (int i = 0; i < 10; i++)
            {
                int randomIndex = _random.Next(MovieManager.Movies.Count);
                ResultLabel.Text = MovieManager.Movies[randomIndex];

                if (i == 9)
                {
                    ResultLabel.TextColor = Colors.Gold;
                    ResultLabel.FontSize = 28;
                }
                else
                {
                    ResultLabel.TextColor = Color.FromRgb(_random.Next(100, 255), _random.Next(100, 255), _random.Next(100, 255));
                    ResultLabel.FontSize = 24;
                }

                int delay = 40 + (i * i * 8);
                await Task.Delay(delay);
            }

            SpinButton.IsEnabled = true;
        }
    }
}
