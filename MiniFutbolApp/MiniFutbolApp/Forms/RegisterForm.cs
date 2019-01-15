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
                    BirthDay=dateTimePicker1.Value


                };

                db.Users.Add(user);
                db.SaveChanges();
         
               
                MessageBox.Show("You've registrered");
            }
        }
    }
}
