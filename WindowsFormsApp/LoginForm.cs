using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {

        private SqlConnection MyConnection;
        private String accountantID;
        private String accountantName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        }

        private void openFrmMain(String accountantID, String accountantName)
        {
            Application.Run(new MainForm(accountantID, accountantName));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            if (verifyLogin(username, password)) 
            {

                MessageBox.Show("Đăng nhập thành công");
                MainForm mainForm = new MainForm(accountantID, accountantName);


                Thread thread = new Thread(() => Application.Run(mainForm));
                thread.Start(); //Khởi chạy luồng*/
                this.Close();

               /* MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();*/

            }
            else
            {

                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to exit.");
            Application.Exit();
        }

        private Boolean verifyLogin(String username, String password)
        {
            MyConnection.Open();

            String querySQL = "SELECT accountantID, accountantName FROM tb_Accountants WHERE username = '" + username + "' and password= '" + password + "'";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            MyConnection.Close();
            if (dataTable.Rows.Count > 0)
            {
                accountantID = dataTable.Rows[0]["accountantID"].ToString();
                accountantName = dataTable.Rows[0]["accountantName"].ToString();

                return true;
            }

            return false;
        }
       
    }
}
