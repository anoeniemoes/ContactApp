using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContactPage : ContentPage
    {
        public NewContactPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Naam = naamEntry.Text,
                Achternaam = achternaamEntry.Text,
                Telefoonnummer = telefoonnummerEntry.Text,
                Email = emailEntry.Text
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path))
            {
                conn.CreateTable<Contact>();
                var numberOfRows = conn.Insert(contact);

                if(numberOfRows > 0)
                    DisplayAlert("Geslaagd!", "Contact is toegevoegd", "Gelukt!");
                else
                    DisplayAlert("Fout", "Contact is niet toegevoegd", "Niet Gelukt!");
            }
        }
    }
}