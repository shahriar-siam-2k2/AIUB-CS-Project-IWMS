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

        private void ClearAllFields(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox txt) txt.Clear();
                else if (c is RichTextBox rtxt) rtxt.Clear();
                else if (c is MaskedTextBox mtxt) mtxt.Clear();
                else if (c is ComboBox cmb) cmb.SelectedIndex = -1;
                else if (c is DateTimePicker dtp)
                {
                    DateTime safeDate = DateTime.Now;

                    if (safeDate > dtp.MaxDate) safeDate = dtp.MaxDate;
                    else if (safeDate < dtp.MinDate) safeDate = dtp.MinDate;

                    dtp.Value = safeDate;
                }
                else if (c is RadioButton rb) rb.Checked = false;

                if (c.HasChildren)
                {
                    ClearAllFields(c);
                }
            }
        }

        private bool checkAgeError()
        {
            dob = dtpDOB.Value;
            age = DateTime.Today.Year - dob.Year;

            if (age < 18)
            {
                lblDOBError.Show();
                return true;
            }
            else
            {
                lblDOBError.Hide();
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
              comboRole.Text == "" || (!rbMale.Checked && !rbFemale.Checked && !rbOthers.Checked)
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

                if (txtEmail.Text == "")
                {
                    lblInvalidEmail.Hide();
                    lblEmailEmpty.Show();
                }
                else
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".") )
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
                hideAllErrorLabels();
                
                if(checkAgeError())
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

                ClearAllFields(this);
            }

        }

        private void hideAllErrorLabels()
        {
            lblNameEmpty.Hide();
            lblUserEmpty.Hide();
            lblPassEmpty.Hide();
            lblConfPassEmpty.Hide();
            lblEmailEmpty.Hide();
            lblPhoneEmpty.Hide();
            lblAddressEmpty.Hide();
            lblDOBError.Hide();
            lblGenderEmpty.Hide();
            lblRoleEmpty.Hide();
            lblInvalidEmail.Hide();
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            hideAllErrorLabels();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}