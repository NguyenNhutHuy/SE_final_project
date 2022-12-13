using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private String accountantID;
        private String accountantName;

        public MainForm(String accountantID, String accountantName)
        {
            InitializeComponent();
            this.accountantID = accountantID;
            this.accountantName = accountantName;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new ImportForm(accountantID, accountantName), panelMain);
        }

        private void byAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new AgentOrderForm(accountantID, accountantName), panelMain);
        }

        private void byCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new CustomerOrderForm(accountantID, accountantName), panelMain);

        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new RevenueStatisticsForm(), panelMain);
        }

        private void showForm(Object Form, Panel panelShow)
        {
            if (panelShow.Controls.Count > 0)
            {
                panelShow.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(f);
            f.Show();
        }
    }
}
