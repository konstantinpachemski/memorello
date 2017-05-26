using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28ProektnaFormsMemorello
{
    public class List
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public List()
        {
            Cards = new List<Card>();
        }
        public List(string Name)
        {
            this.Name = Name;
            Cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
