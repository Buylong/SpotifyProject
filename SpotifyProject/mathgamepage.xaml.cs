namespace SpotifyProject
{
    public partial class mathgamepage : ContentPage
    {
        public mathgamepage()
        {
            InitializeComponent();
        }

        public mathgamepage(string text)
        {
            // Eksik: Yeni bir sayfa oluþtururken burada ne yapýlacaðýný belirtmeniz gerekir.
        }

        private void OnGameChosen(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Navigation.PushAsync(new mathgamepage(button.Text));
        }

        private void OnViewPreviousGameChosen_clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(PreviousGames));
        }
    } // mathgamepage sýnýfý burada kapatýlmalýdýr.
} // Namespace burada kapatýlmalýdýr.
