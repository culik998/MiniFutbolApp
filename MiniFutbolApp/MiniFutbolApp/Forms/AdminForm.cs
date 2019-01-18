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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void createTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTeamForm form = new CreateTeamForm();
            form.ShowDialog();
           
        }
    }
}
