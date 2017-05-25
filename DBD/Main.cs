using System;
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
        }

        private void btnRecreate_Click(object sender, EventArgs e)
        {
            dao.RecreateDB();
        }

        private void btnSQLInjection_Click(object sender, EventArgs e)
        {
            string injectionString = tbSQLInjection.Text;
            dao.SQLinjection(injectionString);
        }
    }
}
