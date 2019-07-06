using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path))
            {
                conn.CreateTable<Contact>();

                var contact = conn.Table<Contact>().ToList();
                contactListView.ItemsSource = contact;
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewContactPage());
        }
    }
}
