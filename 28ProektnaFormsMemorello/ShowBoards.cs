using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28ProektnaFormsMemorello
{
    public partial class ShowBoard : Form
    {
        public static User user;
        public ShowBoard()
        {
            InitializeComponent();
        }
        public ShowBoard(User loggedUser)
        {
            user = loggedUser;
            InitializeComponent();
        }
        public void loadBoards()
        {
            listView1.Items.Clear();
            for (int i = 0; i < user.Boards.Count; i++)
            {
                listView1.Items.Add(user.Boards[i].ToString());
            }
        }

        private void ShowBoards_Load(object sender, EventArgs e)
        {
            loadBoards();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBoard addBoard = new CreateBoard();
            if (addBoard.ShowDialog() == DialogResult.OK)
            {
                user.AddBoard(addBoard.Board);
                loadBoards();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) { 
                RenameBoard renameBoard = new RenameBoard();
                if (renameBoard.ShowDialog() == DialogResult.OK)
                {
                    int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    user.Boards[i].Name = renameBoard.name;
                    loadBoards();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result1 = MessageBox.Show(
                    "Do you really want to delete this board?",
                    "Delete confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    user.Boards.Remove(user.Boards[i]);
                    loadBoards();
                }

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                this.Hide();
                ShowLists showLists = new ShowLists(user, i);
                if(showLists.ShowDialog() == DialogResult.OK)
                {
                    user = showLists.user;
                    this.Show();
                }
            }
        }
    }
}
