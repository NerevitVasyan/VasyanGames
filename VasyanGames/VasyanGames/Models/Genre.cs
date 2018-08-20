using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanGames
{
    public class Genre
    {
        public int ID { get; set; }
        public string NameGenre { get; set; }


        // navigation
        virtual public List<Game> Games { get; set; }
    }
}
