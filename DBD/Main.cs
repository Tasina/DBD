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
            SetupDropdown();
        }

        private void btnRecreate_Click(object sender, EventArgs e)
        {
            dao.RecreateDB();
        }

        public void SetupDropdown()
        {
            foreach (var user in dao.GetUsers())
            {
                cbDropdown.Items.Add(user);
            }
            cbDropdown.SelectedIndex = 0;
        }

        private void btnSQLInjection_Click(object sender, EventArgs e)
        {
            string injectionString = tbSQLInjection.Text;
            dao.SQLinjection(injectionString);
        }
    }
}
