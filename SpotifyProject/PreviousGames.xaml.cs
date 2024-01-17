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
            // text parametresini kullanarak sayfa içeriðini güncelleme veya baþka bir iþlevselliði gerçekleþtirme
        }

        private void OnViewPreviousGameChosen_clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(PreviousGames)}");
        }
    }
}
