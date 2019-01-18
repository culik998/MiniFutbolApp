using MiniFutbolApp.Models;
using MiniFutbolApp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
                    PhotoPath= Path.GetFileName(openFileDialog1.FileName),
                    Status= Status.User
                };

                var valid = this.isValid(user);

                if (valid.Item1)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    var path = Path.Combine(@"C:\Users\User\Desktop\Miniftboll\MiniFutbolApp\MiniFutbolApp\UserPhotos", Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, path);
                    MessageBox.Show($"Player {user.Name} {user.SurName} has been registered");
                    UserForm userForm = new UserForm();
                    userForm.ShowDialog();
                }

                else
                {
                   
                    foreach (var validationResult in this.isValid(user).Item2)
                    {
                        lbl_errors.Text += validationResult.ErrorMessage + "\n";
                    }
                }


             
              
            }
        }

        private void btn_choosephoto_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
            
        }
    }
}
