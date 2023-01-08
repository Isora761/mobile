using System;
using System.Collections.Generic;
using System.Text;

namespace MangaReader.Class
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
        public int[] FavoriteManga { get; set; }
    }
}
