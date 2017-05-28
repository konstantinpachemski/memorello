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
        public int StatusNumber { get; set; }
        public string[] Status = { "Not started", "In progress", "Paused", "Finished" };
        //public enum Status{
        //    NotStarted,
        //    InProgress,
        //    Paused,
        //    Finished
        //};
        public int Priority { get; set; }
        public Card(){}
        public Card(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            Priority = 0;
            StatusNumber = 0;
            //StatusNumber = (int)Status.NotStarted;
        }
        //public string getStatus()
        //{
        //    return string.Format("{0}", Enum.GetName(typeof(Status), StatusNumber));
        //}

    }
}
