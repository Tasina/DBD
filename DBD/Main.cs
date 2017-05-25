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
            foreach (var user in dao.GetUsers())
            {
                cbDropdown.Items.Add(user.Id + " - " + user.Username);
            }
            cbDropdown.SelectedIndex = 0;
        }

        public void PopulateListBox(List<User> users)
        {
            foreach (var user in users)
            {
                lbDBstate.Items.Add(user.Id + " - " + user.Username);
            }
            cbDropdown.SelectedIndex = 0;
        }

        private void btnRecreate_Click(object sender, EventArgs e)
        {
            dao.RecreateDB();
        }



        private void btnSQLInjection_Click(object sender, EventArgs e)
        {
            string injectionString = tbSQLInjection.Text;
            List<User> users = dao.SQLinjection(injectionString);
            PopulateListBox(users);
        }
    }
}
