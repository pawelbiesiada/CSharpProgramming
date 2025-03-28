using BasicCSharpConsoleNET.Exercises;

namespace MyFirstWinFormsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //var names = new List<string>() { "John", "Edd", "Bob", "Tom"};
            var names = CreateCollection.GetUsers()
                .Where(x => x != null)
                //.Select(x => x.Name)
                .ToList();

            cbxNames.DisplayMember = "Name";
            cbxNames.DataSource = names;
        }


        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //txtDescription.Text
            txtTextField.Text += txtDescription.Text + Environment.NewLine;
            txtDescription.Focus();

        }

        private void chbEnableText_CheckedChanged(object sender, EventArgs e)
        {
            txtTextField.ReadOnly = chbEnableText.Checked;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnOK_Click(sender, e);
                ///
                /// //do sht
                ///

                btnOK_Click(sender, e);
            }
        }

        private void cbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userItem = cbxNames.SelectedValue as User;

            if (userItem == null)
                return;

            txtTextField.Text += userItem.Id + ":" +
                userItem.Name + ":" +
                userItem.Password + Environment.NewLine;
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            var users = (List<User>)cbxNames.DataSource;

            //var users = CreateCollection.GetUsers()
            //   .Where(x => x != null)
            //   //.Select(x => x.Name)
            //   .ToList();

            var newFrm = new FrmGrid(users);

            //newFrm.Show();
            newFrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmFileManager().ShowDialog();
        }
    }
}
