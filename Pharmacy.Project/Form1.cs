using Pharmacy.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Project;
namespace PharmacyProject
{
    public partial class Form1 : Form
    {
        PharmacyEntities entity = new PharmacyEntities();
        public Form1()
        {
            InitializeComponent();
        }
        public static Doctor doctor1 = new Doctor();
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var result = entity.Doctors.Where(d => d.UserName == username_box.Text && d.Password == textBox1.Text).ToList();
                if (result.Count() > 0)
                {
                    doctor1 = result[0];
                    label_erorr.Visible = false;
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    username_box.Clear();
                    textBox1.Clear();
                    label_erorr.Visible = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            username_box.Clear();
            textBox1.Clear();
         
            label_erorr.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_erorr.Visible = false;
        }

        private void password_visibility_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox1.PasswordChar = '\0';
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                button1.BringToFront();
                textBox1.PasswordChar = '*';
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label_erorr_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void username_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            label_erorr.Visible = false;
        }
    }
}
