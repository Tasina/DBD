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
            getAll();
        }

        public void getAll()
        {
            using (DBD_UsersContext dbdContext = new DBD_UsersContext())
            {
                foreach (var user in dbdContext.Users)
                {
                    listBox1.Items.Add(user.FirstName + " " + user.LastName + " " + user.Address );
                }
            }
        }
    }
}
