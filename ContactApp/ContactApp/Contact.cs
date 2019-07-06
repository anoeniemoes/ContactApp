using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string Naam { get; set; }

        public string Achternaam { get; set; }

        public string Telefoonnummer { get; set; }

        public string Email { get; set; }
    }
}
