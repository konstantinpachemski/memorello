using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28ProektnaFormsMemorello
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Board> Boards { get; set; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            Boards = new List<Board>();
        }
        public void AddBoard(Board board)
        {
            Boards.Add(board);
        }
    }
}
