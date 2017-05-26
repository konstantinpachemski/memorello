using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28ProektnaFormsMemorello
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Card(){}
        public Card(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
