//Na Li
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace PokeMon_NaLi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        ////https://got-quotes.herokuapp.com/quotes
        //    using (HttpClient client = new HttpClient())
        //    {
        //        var response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?limit=964").Result;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = response.Content.ReadAsStringAsync().Result;
        //            var VARIABLE = JsonConvert.DeserializeObject<Type>(content);
        //            var x = JsonConvert.SerializeObject(VARIABLE);
        //        }
        //    }
        }

        private void ChooseBT_Click(object sender, RoutedEventArgs e)
        {
            //https://pokeapi.co/api/v2/pokemon?limit=964

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?limit=964").Result;
                if(response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    //ChooseBT gq = JsonConvert.DeserializeObject<ChooseBT>(content);
                    var stuff= JsonConvert.DeserializeObject<Results>(content);
                    // pokemonlist.Text = stuff.quote + stuff.charters;
                    foreach (var result in stuff.results)
                    {
                     lstPokes.Items.Add(result.name);
                    }

                }
            }
        }
    }
}
