using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace IWMS
{
    public partial class User_Registration : Form
    {
        string fullName, userName, pass, confPass, email, phone, address, gender, role;
        DateTime dob;
        int age;

        private void ClearAllFields()
        {
            txtFullName.Clear();
            txtUserName.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            txtEmail.Clear();
            rTxtAddress.Clear();
            mtbPhone.Clear();
            comboRole.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOthers.Checked = false;

            if (dtpDOB.MaxDate < DateTime.Today)
            {
                dtpDOB.MaxDate = DateTime.Today;
            }

            dtpDOB.Value = DateTime.Today;

        }

        private bool checkAgeError()
        {
            DateTime dob = dtpDOB.Value;

            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            lblDOBEmpty.Hide();
            lblDOBError.Hide();

            if (age < 0)
            {
                lblAge.Text = "Invalid Date (Future)";
                lblAge.ForeColor = Color.Red;
                lblAge.Show();
                return true;
            }
            else if (age < 18)
            {
                if (age == 0)
                {
                    lblAge.Hide();
                    lblDOBError.Hide();
                    lblDOBEmpty.Show();
                }
                else
                {
                    lblAge.Text = "Age: " + age.ToString() + " year(s)";
                    lblAge.ForeColor = Color.Red;
                    lblAge.Show();

                    lblDOBError.Text = "Must be 18+ to register";
                    lblDOBError.Show();
                }
                return true;
            }
            else
            {
                lblAge.Text = "Age: " + age.ToString() + " year(s)";
                lblAge.ForeColor = Color.Green;
                lblAge.Show();
                return false;
            }
        }

        public User_Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtConfirmPass.Text == "" || txtEmail.Text == "" || !mtbPhone.MaskCompleted || rTxtAddress.Text == "" ||
              comboRole.Text == "" || (!rbMale.Checked && !rbFemale.Checked && !rbOthers.Checked || (txtConfirmPass.Text != "" && txtPass.Text != txtConfirmPass.Text))
              )
            {
                if (txtFullName.Text == "")
                {
                    lblNameEmpty.Show();
                }
                else
                {
                    lblNameEmpty.Hide();
                }

                if (txtUserName.Text == "")
                {
                    lblUserEmpty.Show();
                }
                else
                {
                    lblUserEmpty.Hide();
                }

                if (txtPass.Text == "")
                {
                    lblPassEmpty.Show();
                }
                else
                {
                    lblPassEmpty.Hide();
                }

                if (txtConfirmPass.Text == "")
                {
                    lblConfPassEmpty.Show();
                }
                else
                {
                    lblConfPassEmpty.Hide();
                }

                if (txtConfirmPass.Text != "" && txtPass.Text != txtConfirmPass.Text)
                {
                    lblConfPassError.Show();
                }
                else
                {
                    lblConfPassError.Hide();
                }

                if (txtEmail.Text == "")
                {
                    lblInvalidEmail.Hide();
                    lblEmailEmpty.Show();
                }
                else
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        lblInvalidEmail.Show();
                    }
                    else
                    {
                        lblInvalidEmail.Hide();
                    }

                    lblEmailEmpty.Hide();
                }

                if (!mtbPhone.MaskCompleted)
                {
                    lblPhoneEmpty.Show();
                }
                else
                {
                    lblPhoneEmpty.Hide();
                }

                if (rTxtAddress.Text == "")
                {
                    lblAddressEmpty.Show();
                }
                else
                {
                    lblAddressEmpty.Hide();
                }

                checkAgeError();

                if (!rbMale.Checked && !rbFemale.Checked && !rbOthers.Checked)
                {
                    lblGenderEmpty.Show();
                }
                else
                {
                    lblGenderEmpty.Hide();
                }

                if (comboRole.Text == "")
                {
                    lblRoleEmpty.Show();
                }
                else
                {
                    lblRoleEmpty.Hide();
                }



                //MessageBox.Show("Please fill all the fields and select a gender.");
                //return;
            }
            else
            {
                dob = dtpDOB.Value;

                HideAllErrorLabels();

                if (checkAgeError())
                {
                    return;
                }

                fullName = txtFullName.Text;
                userName = txtUserName.Text;
                pass = txtPass.Text;
                confPass = txtConfirmPass.Text;
                email = txtEmail.Text;
                phone = mtbPhone.Text;
                address = rTxtAddress.Text;
                role = comboRole.Text;

                if (rbMale.Checked)
                    gender = "Male";
                else if (rbFemale.Checked)
                    gender = "Female";
                else if (rbOthers.Checked)
                    gender = "Others";
                else
                    gender = "";

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                string query = "INSERT INTO User_Registration (FullName, UserName, Password, Email, Phone, Address, DOB, Gender, Role) VALUES (@FullName, @UserName, @Password, @Email, @Phone, @Address, @DOB, @Gender, @Role)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                string message = $"Successfully Registered.\n\n" +
                                     $"Full Name: {fullName}\n\n" +
                                     $"User Name: {userName}\n\n" +
                                     $"Password: {pass}\n\n" +
                                     $"Email: {email}\n\n" +
                                     $"Phone: {phone}\n\n" +
                                     $"Address: {address}\n\n" +
                                     $"DOB: {dob.ToShortDateString()}\n\n" +
                                     $"Gender: {gender}\n\n" +
                                     $"Role: {role}\n\n";

                MessageBox.Show(message);

                ClearAllFields();
                HideAllErrorLabels();
            }

        }

        private void HideAllErrorLabels()
        {
            lblNameEmpty.Hide();
            lblUserEmpty.Hide();
            lblPassEmpty.Hide();
            lblConfPassEmpty.Hide();
            lblConfPassError.Hide();
            lblEmailEmpty.Hide();
            lblPhoneEmpty.Hide();
            lblAddressEmpty.Hide();
            lblDOBError.Hide();
            lblGenderEmpty.Hide();
            lblRoleEmpty.Hide();
            lblInvalidEmail.Hide();
            lblDOBEmpty.Hide();
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            lblShowHidePass1.Text = "Show";
            lblShowHidePass2.Text = "Show";
            HideAllErrorLabels();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            checkAgeError();
        }

        private void lblShowHidePass1_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                lblShowHidePass1.Text = "Hide";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                lblShowHidePass1.Text = "Show";
            }
        }

        private void lblShowHidePass2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.UseSystemPasswordChar == true)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                lblShowHidePass2.Text = "Hide";
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
                lblShowHidePass2.Text = "Show";
            }
        }

        private void lblShowHidePass1_MouseEnter(object sender, EventArgs e)
        {
            lblShowHidePass1.Font = new Font(lblShowHidePass1.Font, FontStyle.Underline);
        }

        private void lblShowHidePass1_MouseLeave(object sender, EventArgs e)
        {
            lblShowHidePass1.Font = new Font(lblShowHidePass1.Font, FontStyle.Regular);
        }

        private void lblShowHidePass2_MouseEnter(object sender, EventArgs e)
        {
            lblShowHidePass2.Font = new Font(lblShowHidePass2.Font, FontStyle.Underline);
        }

        private void lblShowHidePass2_MouseLeave(object sender, EventArgs e)
        {
            lblShowHidePass2.Font = new Font(lblShowHidePass2.Font, FontStyle.Regular);
        }
    }
}