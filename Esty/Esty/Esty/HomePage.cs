using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Esty
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Esty";

            var ListView = new ListView();
            ListView.ItemsSource = new ListItemPage[] {
                new ListItemPage {Title = "First Page", PageType = typeof(DataAccessPageRepository) }
            };
        }

        public class ListItemPage
        {
            public string Title { get; set; }
            public Type PageType { get; set; }
        }
    }
}
