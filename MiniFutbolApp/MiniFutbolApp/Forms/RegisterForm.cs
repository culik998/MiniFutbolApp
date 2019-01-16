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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(UserContext db=new UserContext())
            {
                User user = new User
                {
                    Name = textBox_name.Text,
                    SurName = textBox_surname.Text,
                    Password = textBox_password.Text,
                    ConfirmPassword = textBox_confirmpassword.Text,
                    RegisterDate=DateTime.Now,
                    BirthDay=dateTimePicker1.Value,
                    PhotoPath=openFileDialog1.FileName


                };

                db.Users.Add(user);
                db.SaveChanges();


                MessageBox.Show($"Player {user.Name} {user.SurName} has been registered");
            }
        }

        private void btn_choosephoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
