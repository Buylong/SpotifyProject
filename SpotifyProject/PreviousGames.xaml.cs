namespace SpotifyProject
{
    public partial class PreviousGames : ContentPage
    {
        public PreviousGames()
        {
            InitializeComponent();
        }

        public PreviousGames(string text) : this()
        {
            // text parametresini kullanarak sayfa i�eri�ini g�ncelleme veya ba�ka bir i�levselli�i ger�ekle�tirme
        }

        private void OnViewPreviousGameChosen_clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(PreviousGames)}");
        }
    }
}
