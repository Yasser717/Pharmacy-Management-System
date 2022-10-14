using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Project
{
    public partial class Employees : Form
    {
        Employee employee = new Employee();
        EmployeePhoneNumber employeePhoneNumber = new EmployeePhoneNumber();
        public Employees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxFName.Text == "")
                {
                    lbl_Fname.Visible = true;
                }
                if (textBoxLName.Text == "")
                {
                    lbl_Lname.Visible = true;
                }
                if (textBoxCity.Text == "")
                {
                    lbl_city.Visible = true;
                }
                if (textBoxRegion.Text == "")
                {
                    lbl_region.Visible = true;
                }
                if (textBoxPhNum1.Text == "" || textBoxPhNum1.Text.Length != 11 || textBoxPhNum1.Text[0] != '0' || textBoxPhNum1.Text[1] != '1')
                {
                    lbl_phone.Visible = true;
                }
                int age =DateTime.Now.Year-dtpBirth.Value.Year;
                if (age<18)
                {
                    lbl_BirthDate.Visible = true;
                }
                if (textBoxSalary.Text == "")
                {
                    lbl_salary.Visible = true;
                }
                if (textBoxPosition.Text == "")
                {
                    lbl_position.Visible = true;
                }
                if (!(radioButtonMale.Checked) && !(radioButtonFemale.Checked))
                {
                    lbl_GenderEmp.Visible = true;
                }
              
                if (radioButtonMale.Checked)
                {
                employee.Gender = "Male";
                }
                    else if (radioButtonFemale.Checked)
                    {
                        employee.Gender = "Female";
                    }
                    employee.FirstName = textBoxFName.Text.Trim();
                    employee.LastName = textBoxLName.Text.Trim();
                    employee.city = textBoxCity.Text.Trim();
                    employee.Region = textBoxRegion.Text.Trim();
                    employee.Position = textBoxPosition.Text.Trim();
                    employeePhoneNumber.PhoneNumber1 = textBoxPhNum1.Text.Trim();
            if(employeePhoneNumber.PhoneNumber2!=" ")
            {
                employeePhoneNumber.PhoneNumber2 = textBoxPhNum2.Text.Trim();
            }else
            {
                employeePhoneNumber.PhoneNumber2 = " ";
            }

            employee.BirthDate =dtpBirth.Value;
            employee.Salary = int.Parse(textBoxSalary.Text);
                if (radioButton1.Checked==true)
                {
                    employee.ShiftTimeFrom = "9 Am";
                    employee.ShiftTimeTo = "2 Pm";
                }
                if(radioButton2.Checked==true)
                {
                    employee.ShiftTimeFrom = "2 Pm";
                    employee.ShiftTimeTo = "7 Pm";
                }
                 if (radioButton3.Checked==true)
                 {
                    employee.ShiftTimeFrom = "9 Pm";
                    employee.ShiftTimeTo = "12 Am";
                 }
                 if(!(radioButton1.Checked) && (radioButton2.Checked) && (radioButton3.Checked))
                 {
                    lbl_shift.Visible = true;
                 }

               
            employee.Pharmacy_ID = Convert.ToInt32("1");
            }
            catch
            {
             
            }
            using (PharmacyEntities db = new PharmacyEntities())
            {
                try
                {
                    if (employee.ID == 0 && employeePhoneNumber.ID == 0)//Insert
                    {
                        db.EmployeePhoneNumbers.Add(employeePhoneNumber);
                        employee.EmployeePhoneNumbers.Add(employeePhoneNumber);
                        employeePhoneNumber.Employee = employee;
                        db.Employees.Add(employee);
                    }
                    else //Update
                    {
                        db.Entry(employee).State = EntityState.Modified;
                        db.Entry(employeePhoneNumber).State = EntityState.Modified;
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
            textBoxFName.Text = textBoxLName.Text = textBoxCity.Text = textBoxPhNum1.Text = textBoxPhNum2.Text = textBoxPosition.Text =
            textBoxRegion.Text = textBoxSalary.Text = textBoxSalary.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            buttonAdd.Text = "Add";
            buttonDelete.Enabled = false;
            employee.ID = 0;
            employeePhoneNumber.ID = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        void PopulateDataGridView()
        {
            dataGridViewEMP.AutoGenerateColumns = false;
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from Emp in db.Employees
                              join P in db.EmployeePhoneNumbers
                              on Emp.ID equals P.EmployeeID
                              select new
                              {
                                  Emp.ID,
                                  Emp.FirstName,
                                  Emp.LastName,
                                  Emp.Gender,
                                  Emp.Age,
                                  Emp.city,
                                  Emp.Region,
                                  Emp.Position,
                                  Emp.Salary,
                                  Emp.ShiftTimeFrom,
                                  Emp.ShiftTimeTo,
                                  P.PhoneNumber1,
                                  P.PhoneNumber2
                               
                              }).ToList();
                dataGridViewEMP.DataSource = result;

            }
        }
   
        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Delete this Employee", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var entry = db.Entry(employee);
                    if (entry.State == EntityState.Detached)
                        db.Employees.Attach(employee);
                    EmployeePhoneNumber employeePhoneNumber = db.EmployeePhoneNumbers.Where(x => x.EmployeeID == employee.ID).FirstOrDefault();
                    db.EmployeePhoneNumbers.Remove(employeePhoneNumber);
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void dataGridViewEMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEMP_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewEMP.CurrentRow.Index != -1)
            {
                employee.ID = Convert.ToInt32(dataGridViewEMP.CurrentRow.Cells["ID"].Value);
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    employee = db.Employees.Where(x => x.ID == employee.ID).FirstOrDefault();
                    textBoxFName.Text = employee.FirstName;
                    textBoxLName.Text = employee.LastName;
                    textBoxPosition.Text = employee.Position;
                    textBoxCity.Text = employee.city;
                    textBoxRegion.Text = employee.Region;
                    textBoxSalary.Text =Convert.ToString( employee.Salary);
                    dtpBirth.Value =employee.BirthDate.Date;
                    if(employee.ShiftTimeFrom== "9 Am")
                    {
                        radioButton1.Checked = true;
                    }else if(employee.ShiftTimeFrom == "2 Pm")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton3.Checked = true;
                    }
                    

                    employee.Pharmacy_ID = 1;
                    if (employee.Gender == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if (employee.Gender == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    employeePhoneNumber = db.EmployeePhoneNumbers.Where(x => x.EmployeeID == employee.ID).FirstOrDefault();
                    textBoxPhNum1.Text = employeePhoneNumber.PhoneNumber1;
                    textBoxPhNum2.Text = employeePhoneNumber.PhoneNumber2;
                }
                buttonAdd.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_Fname.Visible = false;
        }

        private void textBoxLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_Lname.Visible = false;
        }

        private void textBoxPhNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhNum1_KeyPress(object sender, KeyPressEventArgs e)
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
            lbl_phone.Visible = false;
        }

        private void textBoxPhNum2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_salary.Visible = false;
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_city.Visible = false;
        }

        private void textBoxShiftIN_KeyPress(object sender, KeyPressEventArgs e)
        {
         

        }

        private void textBoxShiftOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_position.Visible = false;
        }

        private void textBoxShiftIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpShiftS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirth_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_BirthDate.Visible = false;
        }

        private void radioButtonMale_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void radioButtonFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_region.Visible = false;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            lbl_GenderEmp.Visible = false;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            lbl_GenderEmp.Visible = false;
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            lbl_BirthDate.Visible = false;
        }

        private void dtpBirth_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_shift.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_shift.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbl_shift.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
