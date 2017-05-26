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
    public partial class ShowLists : Form
    {
        public User user;
        public int bIndex;
        public ShowLists()
        {
            InitializeComponent();
        }
        public ShowLists(User loggedUser, int boardIndex)
        {
            user = loggedUser;
            bIndex = boardIndex;
            InitializeComponent();
        }
        public void loadLists()
        {
            listView1.Items.Clear();
            for (int i = 0; i < user.Boards[bIndex].Lists.Count; i++)
            {
                listView1.Items.Add(user.Boards[bIndex].Lists[i].ToString());
            }
        }

        private void ShowLists_Load(object sender, EventArgs e)
        {
            loadLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateList addList = new CreateList();
            if (addList.ShowDialog() == DialogResult.OK)
            {
                user.Boards[bIndex].AddList(addList.list);
                loadLists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) { 
                RenameList renameList = new RenameList();
                if (renameList.ShowDialog() == DialogResult.OK)
                {
                    int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    user.Boards[bIndex].Lists[i].Name = renameList.name;
                    loadLists();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result1 = MessageBox.Show(
                    "Do you really want to delete this lists?",
                    "Delete confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    user.Boards[bIndex].Lists.Remove(user.Boards[bIndex].Lists[i]);
                    loadLists();
                }
            
            }
        }
    }
}
