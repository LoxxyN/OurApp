namespace OurApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.HistoryPage), typeof(Views.HistoryPage));
        }
    }
}
