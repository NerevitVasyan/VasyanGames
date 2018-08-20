using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VasyanGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        ObservableCollection<Game> Games = new ObservableCollection<Game>();
        List<string> GenreNames = new List<string>();
        public MainWindow()
        {
            InitializeComponent();


            //Add Genres
            using (Vasyan db = new Vasyan())
            {
                foreach (var genre in db.Genres.ToList())
                {
                    CheckBox ch = new CheckBox();
                    ch.Content = genre.NameGenre;
                    ch.Checked += CheckBox_Checked;
                    ch.Unchecked += CheckBox_Unchecked;
                    StackGenres.Children.Add(ch);
                }

                foreach (var prod in db.Producers.ToList())
                {
                    CheckBox ch = new CheckBox();
                    ch.Content = prod.NameProducer;
                    ch.Checked += CheckBox_Checked;
                    ch.Unchecked += CheckBox_Unchecked;
                    StackProducers.Children.Add(ch);
                }
            }
            

            listbox1.ItemsSource = Games;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            flyoutsettings.IsOpen = true;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            string genre = (sender as CheckBox).Content.ToString();

            if(genre=="All")
            {
                Vasyan db = new Vasyan();
                foreach(Game game in db.Games.ToList())
                {
                    Games.Add(game);
                }
            }
            else 
            {
                Vasyan db = new Vasyan();
                foreach (Game game in db.Games.Where(x=>x.Genre.NameGenre==genre).ToList())
                {
                    Games.Add(game);
                }
            }
           
        }


        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
           // Games.Clear();
            string genre = (sender as CheckBox).Content.ToString();

            if (genre == "All")
            {
                //Vasyan db = new Vasyan();
                //foreach (Game game in db.Games.ToList())
                //{
                //    Games.Add(game);
                //}
            }
            else
            {
                Vasyan db = new Vasyan();
                foreach (Game game in db.Games.Where(x => x.Genre.NameGenre == genre).ToList())
                {
                    Games.Remove(Games.FirstOrDefault(x => x.Name == game.Name));
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start((sender as Button).Tag.ToString());
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            flyoutsettings.IsOpen = false;
          

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            var list = Games.OrderByDescending(x => x.Score).ToList();
            Games.Clear();
            foreach(var game in list)
            {
                Games.Add(game);
            }
        }

        private void ToggleButton_Unchecked_1(object sender, RoutedEventArgs e)
        {
            var list = Games.OrderBy(x => x.Score).ToList();
            Games.Clear();
            foreach (var game in list)
            {
                Games.Add(game);
            }
        }

        private void AllGenresCheck(object sender, RoutedEventArgs e)
        {
            foreach(var ch in StackGenres.Children)
            {
                (ch as CheckBox).IsChecked = true;
            }
        }

        int flyoutfocus = 0;

        private void flyoutsettings_LostFocus(object sender, RoutedEventArgs e)
        {
            flyoutfocus++;

            if(flyoutfocus==2)
            {
                (sender as Flyout).IsOpen = false;
                flyoutfocus = 0;
                
            }
            
        }
    }
}
