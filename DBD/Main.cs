﻿
using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DBD
{
    public partial class Main : Form
    {
        private DBD_DAO dao = new DBD_DAO();

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dao.RecreateDB();
            PopulateDropdown();
            cbDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PopulateDropdown()
        {
            cbDropdown.Items.Clear();
            if(dao.GetUsers().Count < 1)
            {
                cbDropdown.Text = "No Users";
            }else
            {
                foreach (var user in dao.GetUsers())
                {
                    cbDropdown.Items.Add(user.Id + " - " + user.Username);
                }
                cbDropdown.SelectedIndex = 0;
            }

        }

        public void PopulateListBox(List<User> users)
        {
            if(users.Count < 1)
            {
                MessageBox.Show("user not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbDBstate.Items.Clear();
            foreach (var user in users)
            {
                lbDBstate.Items.Add(user.Id + " - " + user.Username);
            }
        }

        private void btnRecreate_Click(object sender, EventArgs e)
        {
            dao.RecreateDB();
            tbRegularExpression.Clear();
            tbSQLInjection.Clear();
            tbPreparedStatement.Clear();
            tbStoredProcedure.Clear();
            PopulateDropdown();
        }



        private void btnSQLInjection_Click(object sender, EventArgs e)
        {
            string injectionString = tbSQLInjection.Text;
            if (injectionString.Length > 0)
            {
                List<User> users = dao.SQLinjection(injectionString);
                PopulateDropdown();
                PopulateListBox(users);
            }
        }


        private void btnRegularExpression_Click(object sender, EventArgs e)
        {
            string text = tbRegularExpression.Text;

            Regex regex = new Regex("\\D.+");
            text = regex.Replace(text, "");
            tbRegularExpression.Text = text;

            List<User> users = dao.SQLinjection(text);
            PopulateDropdown();
            PopulateListBox(users);
        }

        private void btnStoredProcedure_Click(object sender, EventArgs e)
        {
            string text = tbStoredProcedure.Text;

            List<User> users = dao.StoredProcedure(text);

            PopulateDropdown();
            PopulateListBox(users);
        }

        private void btnPreparedStatement_Click(object sender, EventArgs e)
        {
            if(tbPreparedStatement.Text.Length > 0)
            {
                List<User> users = dao.PreparedStatement(tbPreparedStatement.Text);
                tbPreparedStatement.Clear();
                PopulateDropdown();
                PopulateListBox(users);
            }
        }
    }
}
