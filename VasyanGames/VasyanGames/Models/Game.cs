using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanGames.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Score { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }

        // navigation
        virtual public Genre Genre { get; set; }
        virtual public Producer Producer { get; set; }

    }

}
