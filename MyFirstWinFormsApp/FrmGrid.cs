using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCSharpConsoleNET.Exercises;

namespace MyFirstWinFormsApp
{
    public partial class FrmGrid : Form
    {
        private IList<User> _users;
        public FrmGrid(IList<User> users)
        {
            _users = users;
            InitializeComponent();
        }

        private void FrmGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _users;
        }
    }
}
