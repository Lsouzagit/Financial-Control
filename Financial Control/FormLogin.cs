using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Financial_Control
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string Password = txtPassword.Text;
            //query
            if(Convert.ToBoolean(this.login_dataTableAdapter.FillByLogin(this.finantialcontroldbDataSet1.login_data, username, Password)))
            {
                //We will display Form1 if login suceed
                MessageBox.Show("Welcome!");
                new formFinantialControl().ShowDialog();
                this.Close();
                //formFinantialControl home = new formFinantialControl();
                //home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void login_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finantialcontroldbDataSet1);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finantialcontroldbDataSet1.login_data' table. You can move, or remove it, as needed.
            //this.login_dataTableAdapter.Fill(this.finantialcontroldbDataSet1.login_data);

        }
    }
}
