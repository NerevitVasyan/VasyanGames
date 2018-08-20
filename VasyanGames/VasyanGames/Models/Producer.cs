using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyanGames
{
    public class Producer
    {
        public int ID { get; set;}
        public string NameProducer { get; set; }


        // navigation
        virtual public List<Game> Games { get; set; }

    }
}
