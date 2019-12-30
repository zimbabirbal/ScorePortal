using ScorePortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScorePortal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedTournament : ContentPage
    {
        List<string> Teams;
        public AdvancedTournament()
        {

            List<string> Teams = new List<string>();
            InitializeComponent();
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            searchResults.ItemsSource = FetchTeam.GetSearchResults(searchBar.Text);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = FetchTeam.GetSearchResults(e.NewTextValue);
        }

        private void searchBar1_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults1.ItemsSource = FetchTeam.GetSearchResults(e.NewTextValue);
        }

        private void searchBar1_Focused(object sender, FocusEventArgs e)
        {
            searchBar1.IsVisible = true;
        }

        private void searchBar1_Unfocused(object sender, FocusEventArgs e)
        {
            searchBar1.IsVisible = false;
        }

        private void searchResults1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            searchBar1.IsVisible = false;
            Teams.Add(e.SelectedItem.ToString());
            innerSearchResults1.ItemsSource = Teams;
        }
    }
}