using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user_box_TextChanged(object sender, EventArgs e)
        {

        }     

        private void email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(user_box.Text =="" || email_box.Text =="" || pass_box.Text =="")
            {
                MessageBox.Show("Vui lòng nhập thông tin!","Thông báo");
            }
            else if(!IsValidEmail(email_box.Text))
            {
                MessageBox.Show("Email không đúng định dạng!", "Thông báo");
            }
            else if (!IsValidPassword(pass_box.Text))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng ký thành công!","Thông báo");
            }
        }
    }
}
