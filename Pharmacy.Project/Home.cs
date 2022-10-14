using PharmacyProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors doctor = new Doctors();
            doctor.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            if(Form1.doctor1.Responsibility == "Pharmacist")
            {
                contract_btn.Enabled = false;
                button3.Enabled = false;
                buttonDoctor.Enabled = false;
                button1.Enabled = false;

            }






        }

        private void contract_btn_Click(object sender, EventArgs e)
        {
            DrugManufactrueer drugManufactrueer = new DrugManufactrueer();
            this.Hide();
            drugManufactrueer.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            this.Hide();
            medicine.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            this.Hide();
            employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prescripes prescripes = new Prescripes();
            this.Hide();
            prescripes.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_MedValidChk_Click(object sender, EventArgs e)
        {
            MedicineValidityCheck medicineValidityCheck = new MedicineValidityCheck();
            this.Hide();
            medicineValidityCheck.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            this.Hide();
            dashBoard.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
