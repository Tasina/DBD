using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBD.DAL;
using DBD.DAL.Models;

namespace DBD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SeedDB();
            SetupDropdown();
        }

        public void SeedDB()
        {
            DBD_UsersContext dbContext = new DBD_UsersContext();
            dbContext.Users.FirstOrDefault();
        }

        public void SetupDropdown()
        {
            DBD_DAO dao = new DBD_DAO();
            foreach(var user in dao.GetUsers())
            {
                cbDropdown.Items.Add(user);
            }
            cbDropdown.SelectedIndex = 0;
        }

        private void btnRecreate_Click(object sender, EventArgs e)
        {
            DBD_DAO dao = new DBD_DAO();
            dao.RecreateDB();
        }
    }
}
