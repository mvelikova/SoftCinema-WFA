﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
         
        }

        private void UserList_Load(object sender, System.EventArgs e)
        {
            string[] usernames = UserService.GetUsernames();

            foreach (var username in usernames)
            {
                UserList.Items.Add(username);
            }
            
        }

        private void UserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserDetailsForm userForm = new UserDetailsForm();
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            this.Hide();
            ((ListBox)sender).Parent.Parent.Parent.Controls.Add(userForm);
            userForm.Show();
        }
    }
}
