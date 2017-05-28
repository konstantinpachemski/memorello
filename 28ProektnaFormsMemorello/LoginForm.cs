using _28ProektnaFormsMemorello.Login;
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
    public partial class LoginForm : Form
    {
        static List<User> users = new List<User>();
        public static User loggedUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User guestUser = new User("guest", "guest");
            users.Add(guestUser);

            Board guestBoard = new Board("My life");
            guestUser.AddBoard(guestBoard);
            for(int i=0; i < guestUser.Boards.Count; i++)
            {
                List temp1 = new List("Things i need to do today");
                List temp2 = new List("University life for three months");
                guestUser.Boards[i].AddList(temp1);
                guestUser.Boards[i].AddList(temp2);
                for (int j = 0; j < guestUser.Boards[i].Lists.Count; j++)
                {
                    if(j == 0) { 
                        Card temp11 = new Card("Get up from bed", "The first thing i need to do it get up");
                        Card temp22 = new Card("Go to work", "The second thing is that I need to do work work");
                        Card temp33 = new Card("If not ded - repeat again", "The last thing i need now is to die");
                        guestUser.Boards[i].Lists[j].AddCard(temp11);
                        guestUser.Boards[i].Lists[j].AddCard(temp22);
                        guestUser.Boards[i].Lists[j].AddCard(temp33);
                    }
                    if(j == 1)
                    {
                        Card temp11 = new Card("Pass DM1", "The first thing i need to pass DM1");
                        Card temp22 = new Card("Pass VP", "The second thing is that I need to pass VP");
                        Card temp33 = new Card("Pass the blunt", "The last thing i need is to share this");
                        guestUser.Boards[i].Lists[j].AddCard(temp11);
                        guestUser.Boards[i].Lists[j].AddCard(temp22);
                        guestUser.Boards[i].Lists[j].AddCard(temp33);
                    }
                }
            }
            
        }
        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            CreateLoginForm createLoginForm = new CreateLoginForm();
            if(createLoginForm.ShowDialog() == DialogResult.OK)
            {
                users.Add(createLoginForm.user);
                usernameBox.Text = createLoginForm.user.Username;
                passwordBox.Text = createLoginForm.user.Password;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool usernameFound = false;
            bool passwordFound = false;
            for (int i = 0; i < users.Count; i++)
                if (users[i].Username.Equals(usernameBox.Text.Trim()))
                {
                    usernameFound = true;
                    if (users[i].Password.Equals(passwordBox.Text.Trim()))
                    {
                        this.Hide();
                        passwordFound = true;
                        ShowBoard showBoards = new ShowBoard(users[i]);
                        if (showBoards.ShowDialog() == DialogResult.OK)
                        {
                            users[i] = showBoards.user;
                            this.Show();
                        }

                        break;

                    }
                    else if(!passwordFound)
                    {
                        MessageBox.Show("Password does not match.");
                        passwordFound = false;
                    }
                }
            if (!usernameFound)
            {
                MessageBox.Show("No such username registered");
            }
        }

    }
}

