using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28ProektnaFormsMemorello
{
    public class Board
    {
        public string Name { get; set; }
        public List<List> Lists { get; set; }
        public Board()
        {
            Lists = new List<List>();
        }
        public Board(string Name)
        {
            this.Name = Name;
            Lists = new List<List>();
        }
        public void AddList(List list)
        {
            Lists.Add(list);
        }
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
