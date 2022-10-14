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
    public partial class DashBoard : Form
    {
        Bill bill = new Bill();
        Drug drug = new Drug();
        Doctor doctor = new Doctor();
        Employee employee = new Employee();
        DrugManufactruer drugManufactruer = new DrugManufactruer();
        Prescribe prescribe = new Prescribe();
        public DashBoard()
        {
            InitializeComponent();
            CountMed();
            CountDoc();
            CountEmp();
            CountDrugManufactruer();
            CountSell();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private void CountMed()
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {     
                var result = db.Drugs.Count();
                label8.Text = result.ToString();
            }

        }
        private void CountDoc()
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = db.Doctors.Count();
                label9.Text = result.ToString();
            }

        }
        private void CountEmp()
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = db.Employees.Count();
                label10.Text = result.ToString();
            }
        }
        private void CountDrugManufactruer()
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = db.DrugManufactruers.Count();
                label12.Text = result.ToString();
            }

        }
        private void CountSell() 
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                List<Bill> bills = db.Bills.ToList();
                decimal total_price = 0;
                for (int i=0; i<db.Bills.Count(); ++i)
                {
                    decimal price =(Decimal)bills[i].TotalPrice;
                    total_price += price;
                }
                label11.Text = total_price.ToString();
            }

        }
        void PopulateDataGridView()
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from B in db.Bills
                              select new { B.BillID, B.DrugName, B.NumberOfUnits, B.Price, B.TotalPrice, B.ExpiryDate }).ToList();
                dgv_history.DataSource = result;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_history_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_history.CurrentRow.Index != -1)
                {
                    bill.BillID = Convert.ToInt32(dgv_history.CurrentRow.Cells["ID"].Value);
                    using (PharmacyEntities db = new PharmacyEntities())
                    {
                        bill = db.Bills.Where(b => b.BillID == bill.BillID).FirstOrDefault();
                        pharmacist_nameBox.Text = bill.PharmacistName;
                        customer_nameBox.Text = bill.CustomerName;
                        selling_dateBox.Text = bill.SellingDate.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selling_dateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
