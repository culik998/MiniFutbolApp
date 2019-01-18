using MiniFutbolApp.Infrastucture;
using MiniFutbolApp.Models;
using MiniFutbolApp.Validation;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            lbl_errors.Text = "";

            LoginModel loginModel = new LoginModel
            {
                Name = textBox_name.Text,
                Password = textBox_password.Text
            };

            var valid = this.isValid(loginModel);


            User loggedUser = null;


            if (valid.Item1)
            {
                using (UserContext db = new UserContext())
                {
                    loggedUser = db.Users.GetUser(loginModel);
                }
                if (loggedUser != null)
                {
                    if (loggedUser.Status == Status.Admin)
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        UserForm userForm = new UserForm();
                        userForm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Couldn't find user");
                }
 
            }
            else
            {
                foreach (var validationResult in valid.Item2)
                {
                    lbl_errors.Text += validationResult.ErrorMessage + "\n";
                }
            }


        }
    }
}
