using MiniFutbolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFutbolApp.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome";


            // TODO: This line of code loads data into the 'miniFootballDbDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.miniFootballDbDataSet1.Users);
            // TODO: This line of code loads data into the 'miniFootballDbDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.miniFootballDbDataSet.Teams);
          





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
