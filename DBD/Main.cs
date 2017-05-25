
using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBD
{
    public partial class Main : Form
    {
        private DBD_DAO dao = new DBD_DAO();

        public Main()
        {
            InitializeComponent();
            dao.RecreateDB();
            PopulateDropdown();

            cbDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PopulateDropdown()
        {
            cbDropdown.Items.Clear();
            foreach (var user in dao.GetUsers())
            {
                cbDropdown.Items.Add(user.Id + " - " + user.Username);
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
            PopulateDropdown();
        }



        private void btnSQLInjection_Click(object sender, EventArgs e)
        {
            string injectionString = tbSQLInjection.Text;
            if (injectionString.Length > 0)
            {
                List<User> users = dao.SQLinjection(injectionString);
                tbSQLInjection.Clear();
                PopulateDropdown();
                PopulateListBox(users);
            }
        }
    }
}
