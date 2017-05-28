using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _28ProektnaFormsMemorello.Card;

namespace _28ProektnaFormsMemorello
{
    public partial class ShowCards : Form
    {
        public User user;
        public int bIndex;
        public int lIndex;
        public ShowCards()
        {
            InitializeComponent();
        }
        public ShowCards(User loggedUser, int boardIndex, int listIndex)
        {
            user = loggedUser;
            bIndex = boardIndex;
            lIndex = listIndex;
            InitializeComponent();
        }
        public void loadCards()
        {
            listView1.Items.Clear();
            if(user.Boards[bIndex].Lists[lIndex].Cards.Count > 0) { 
                for (int i = 0; i < user.Boards[bIndex].Lists[lIndex].Cards.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem(user.Boards[bIndex].Lists[lIndex].Cards[i].Name); //1
                    item1.SubItems.Add(user.Boards[bIndex].Lists[lIndex].Cards[i].Description);             //2
                    if (user.Boards[bIndex].Lists[lIndex].Cards[i].Priority == 0)                           //{
                    {
                        item1.SubItems.Add("");
                    }                                                                                       //3
                    else
                    {
                        item1.SubItems.Add(user.Boards[bIndex].Lists[lIndex].Cards[i].Priority.ToString()); //}
                    }
                    //item1.SubItems.Add(user.Boards[bIndex].Lists[lIndex].Cards[i].getStatus());           //4
                    item1.SubItems.Add(user.Boards[bIndex].Lists[lIndex].Cards[i].Status[user.Boards[bIndex].Lists[lIndex].Cards[i].StatusNumber]);
                    listView1.Items.Add(item1);
                }
            }

            //listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ShowCards_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name", 140);
            listView1.Columns.Add("Description", 280);
            listView1.Columns.Add("Priority", 90);
            listView1.Columns.Add("Status", 73);
            loadCards();
        }

        private void ShowCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void createCardButton_Click(object sender, EventArgs e)
        {
            CreateCard addCard = new CreateCard();
            if (addCard.ShowDialog() == DialogResult.OK)
            {
                user.Boards[bIndex].Lists[lIndex].Cards.Add(addCard.card);
                loadCards();
            }
        }

        private void deleteCardButton_Click(object sender, EventArgs e)
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
                    user.Boards[bIndex].Lists[lIndex].Cards.Remove(user.Boards[bIndex].Lists[lIndex].Cards[i]);
                    loadCards();
                }

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                CreateCard createCard = new CreateCard(user.Boards[bIndex].Lists[lIndex].Cards[i]);
                if (createCard.ShowDialog() == DialogResult.OK)
                {
                    user.Boards[bIndex].Lists[lIndex].Cards[i] = createCard.card;
                    loadCards();
                }
            }
            
        }
    }
}
