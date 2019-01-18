using MiniFutbolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFutbolApp.Forms
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_createteam_Click(object sender, EventArgs e)
        {
            Team team = new Team
            {

                Name = textBox_name.Text,
                CreatedDate = dateTimePicker1.Value,
                PhotoPath = Path.GetFileName(openFileDialog1.FileName),
                

            };

            using(UserContext db=new UserContext())
            {
               

                db.Teams.Add(team);
                db.SaveChanges();

                var path = Path.Combine(@"C:\Users\User\Desktop\Miniftboll\MiniFutbolApp\MiniFutbolApp\TeamLogos", Path.GetFileName(openFileDialog1.FileName));
                File.Copy(openFileDialog1.FileName, path);

            }

            if (team!=null)
            {
                this.Hide();
                MessageBox.Show($"{team.Name} have been registered succesfully!!!");
            }
            else
            {
                MessageBox.Show("Please try again");
            }



        }
    }
}
