using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon_NaLi
{
    class pokemon
    {
        public int height { get; set; }
        public int weight { get; set; }
        public string name { get; set; }

        public List<Result> results { get; set; }

   

        public override string ToString()
        {
            return $"{name} is {height} in height, and {weight} in weight";
        }
    }
}
