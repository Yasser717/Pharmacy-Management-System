using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Project
{
    public partial class Doctors : Form
    {
        Doctor doctor = new Doctor();
        DoctorPhoneNumber doctorPhoneNumber = new DoctorPhoneNumber();
        public Doctors()
        {
            InitializeComponent();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var list = db.Doctors.ToList();
                    for (int i = 0;i<db.Doctors.Count();i++)
                    {
                        if (list[i].UserName == username_box.Text)
                        {
                            lbl_Username.Visible = true;
                        }

                    }
                }
                        if (firstname_box.Text == "")
                        {
                            lbl_FName.Visible = true;
                        }
                if(secondname_box.Text == "")
                {
                    lbl_LName.Visible = true;
                }
                if (phone1_box.Text == ""||phone1_box.Text.Length!=11||phone1_box.Text[0]!='0'||phone1_box.Text[1]!='1')
                {
                    lbl_Phone.Visible = true;
                }
                if (username_box.Text == "")
                {
                    lbl_Username.Visible = true;
                }
                if (password_box.Text == "")
                {
                    label16.Visible = true;
                }
                if (!(male_radioButton.Checked) && !(female_radioButton.Checked))
                {
                    lbl_Gender.Visible = true;
                }

                if (responsibilty_checker.Checked)
                {
                    doctor.Responsibility = "Admin";
                }
                else
                {
                    doctor.Responsibility = "Pharmacist";
                }
                doctor.FirstName = firstname_box.Text.Trim();
                doctor.LastName = secondname_box.Text.Trim();
                if (male_radioButton.Checked)
                {
                    doctor.Gender = "Male";
                }
                else if (female_radioButton.Checked)
                {
                    doctor.Gender = "Female";
                }
                doctor.UserName = username_box.Text.Trim();
                doctor.salary =Convert.ToInt32(txt_Salary.Text);
                doctor.Password = password_box.Text.Trim();
                doctorPhoneNumber.PhoneNumber1 = phone1_box.Text.Trim();
                if (doctorPhoneNumber.PhoneNumber2 != " ")
                {
                    doctorPhoneNumber.PhoneNumber2 = phone2_box.Text.Trim();
                }
                else
                {
                    doctorPhoneNumber.PhoneNumber2 = " ";
                }
            }
            catch 
            {

            }
       
            using (PharmacyEntities db = new PharmacyEntities())
            {
                try
                {
                    if (doctor.ID == 0 && doctorPhoneNumber.ID==0)//Insert
                    {
                        db.DoctorPhoneNumbers.Add(doctorPhoneNumber);
                        doctor.DoctorPhoneNumbers.Add(doctorPhoneNumber);
                        doctorPhoneNumber.Doctor = doctor;
                        db.Doctors.Add(doctor);
                    }
                    else //Update
                    {
                        lbl_Username.Visible = false;
                        db.Entry(doctor).State = EntityState.Modified;
                        db.Entry(doctorPhoneNumber).State = EntityState.Modified;
                    }
                    db.SaveChanges();      
                    MessageBox.Show("Saved Successfully");
                }
                catch 
                {
                }
            }
            Clear();
            PopulateDataGridView();
        }
        void Clear()
        {
            firstname_box.Text = secondname_box.Text = username_box.Text = password_box.Text =phone1_box.Text=phone2_box.Text=txt_Salary.Text="";
            responsibilty_checker.Checked = false;
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;
            add_btn.Text = "Add";
            delete_btn.Enabled = false;
            doctor.ID = 0;
            doctorPhoneNumber.ID = 0;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void PopulateDataGridView()
        {
            dgv_doctors.AutoGenerateColumns = false;
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from D in db.Doctors
                             join P in db.DoctorPhoneNumbers
                             on D.ID equals P.DoctorID
                             select new { D.ID, D.FirstName, D.LastName, D.Gender, D.UserName, D.Password,D.salary, P.PhoneNumber1, P.PhoneNumber2,D.Responsibility }).ToList();
                dgv_doctors.DataSource = result;
            }
           
        }
     

        private void Doctors_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void dgv_doctors_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_doctors.CurrentRow.Index != -1)
                {
                    doctor.ID = Convert.ToInt32(dgv_doctors.CurrentRow.Cells["ID"].Value);
                    using (PharmacyEntities db = new PharmacyEntities())
                    {
                        doctor = db.Doctors.Where(x => x.ID == doctor.ID).FirstOrDefault();
                        firstname_box.Text = doctor.FirstName;
                        secondname_box.Text = doctor.LastName;
                        username_box.Text = doctor.UserName;
                        password_box.Text = doctor.Password;
                        txt_Salary.Text = Convert.ToString(doctor.salary);
                        if (doctor.Responsibility == "Admin")
                        {
                            responsibilty_checker.Checked = true;
                        }
                        else
                        {
                            responsibilty_checker.Checked = false;
                        }
                        if (doctor.Gender == "Male")
                        {
                            male_radioButton.Checked = true;
                        }
                        else if (doctor.Gender == "Female")
                        {
                            female_radioButton.Checked = true;
                        }
                        doctorPhoneNumber = db.DoctorPhoneNumbers.Where(x => x.DoctorID == doctor.ID).FirstOrDefault();
                        phone1_box.Text = doctorPhoneNumber.PhoneNumber1;
                        phone2_box.Text = doctorPhoneNumber.PhoneNumber2;
                    }
                }
            }
            catch
            {

            }
                add_btn.Text = "Update";
                delete_btn.Enabled = true;
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Delete this Doctor", "Delete", MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                using(PharmacyEntities db = new PharmacyEntities())
                {
                    var entry = db.Entry(doctor);
                    if (entry.State == EntityState.Detached)
                        db.Doctors.Attach(doctor);
                    DoctorPhoneNumber doctorPhoneNumber = db.DoctorPhoneNumbers.Where(x => x.DoctorID == doctor.ID).FirstOrDefault();
                    db.DoctorPhoneNumbers.Remove(doctorPhoneNumber);
                    db.Doctors.Remove(doctor);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void phone1_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) == 11)
                {
                    e.Handled = true;
                }
            }
            lbl_Phone.Visible = false;
        }


        private void phone2_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) == 11)
                {
                    e.Handled = true;
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void firstname_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_FName.Visible = false;
        }

        private void secondname_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_LName.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phone1_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void responsibilty_checker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phone2_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Phone_Click(object sender, EventArgs e)
        {

        }

        private void username_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Username.Visible = false;
        }

        private void password_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            label16.Visible = false;
        }

        private void male_radioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void female_radioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void female_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Gender.Visible = false;
        }

        private void male_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Gender.Visible = false;
        }

        private void Doctors_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txt_Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
