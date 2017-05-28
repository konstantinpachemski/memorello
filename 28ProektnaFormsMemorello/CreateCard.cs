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
    public partial class CreateCard : Form
    {
        public Card card;
        public CreateCard()
        {
            InitializeComponent();
        }
        public CreateCard(Card thisCard)
        {
            card = thisCard;
            InitializeComponent();
            nameBox.Text = card.Name;
            descriptionBox.Text = card.Description;
        }


        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!nameValidate(nameBox.Text.Trim()))
            {
                card = new Card(nameBox.Text.Trim(), descriptionBox.Text.Trim());
                DialogResult = DialogResult.OK;
            }

        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = nameValidate(nameBox.Text.Trim());
        }
        bool nameValidate(string name)
        {
            if (name.Length == 0)
            {
                errorProvider1.SetError(nameBox, "You must enter name.");
                return true;
            }
            else
            {
                errorProvider1.SetError(nameBox, null);
                return false;
            }
        }

        private void CreateCard_Load(object sender, EventArgs e)
        {

        }
    }
}
