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
        }

        public void SeedDB()
        {
            DBD_UsersContext dbContext = new DBD_UsersContext();
            dbContext.Users.FirstOrDefault();
        }
    }
}
