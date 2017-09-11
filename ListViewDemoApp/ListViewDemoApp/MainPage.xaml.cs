using ListViewDemoApp.Factory;
using ListViewDemoApp.Model;
using Xamarin.Forms;

namespace ListViewDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            playerListView.ItemsSource = PlayersFactory.Players;
        }

        private void OnDelete(object sender, System.EventArgs e)
        {
            var listItem = ((MenuItem)sender);
            var player = (Player)listItem.CommandParameter;

            PlayersFactory.Players.Remove(player);
        }
    }
}