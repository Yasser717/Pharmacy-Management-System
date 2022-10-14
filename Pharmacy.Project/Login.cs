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

namespace PharmacyProject
{
    public partial class Login : UserControl
    {
        PharmacyEntities entity = new PharmacyEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_username_Click(object sender, EventArgs e)
        {
            try
            {
                var result = entity.Doctors.Where(d => d.UserName == username_box.Text && d.Password == password_box.Text).ToList();
                if (result.Count() > 0)
                {
                    label_erorr.Visible = false;
                    Home home = new Home();
                    Form1 form = new Form1();
                    form.Hide();
                    home.Show();
                }
                else
                {
                    label_erorr.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            username_box.Clear();
            password_box.Clear();
            checkBox1.Checked = false;
            label_erorr.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label_erorr.Visible = false;
        }
    }
}
