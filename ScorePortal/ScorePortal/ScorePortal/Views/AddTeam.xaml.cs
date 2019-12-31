using ScorePortal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScorePortal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTeam : ContentPage
    {
        public ObservableCollection<Player> PlayerList { get; set; }
        private int playerListRowHeight = 48;
        public AddTeam()
        {
            InitializeComponent();
            PlayerList = new ObservableCollection<Player>();
            playerList.ItemsSource = PlayerList;
            playerList.HeightRequest = playerListRowHeight * PlayerList.Count;
        }

        private void Add_Player_Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(playerNameEntry.Text))
            {
                PlayerList.Add(new Player { Name = playerNameEntry.Text, Info = playerInfoEntry.Text });
                playerList.ItemsSource = PlayerList;
                playerList.HeightRequest = playerListRowHeight * PlayerList.Count;
                playerInfoEntry.Text = string.Empty;
                playerNameEntry.Text = string.Empty;
            }
        }

        private void playerList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            PlayerList.RemoveAt(e.ItemIndex);
            playerList.ItemsSource = PlayerList;
            playerList.HeightRequest = playerListRowHeight * PlayerList.Count;
        }
    }
}