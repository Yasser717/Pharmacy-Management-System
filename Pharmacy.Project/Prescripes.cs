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
using DGVPrinterHelper;

namespace Pharmacy.Project
{
    public partial class Prescripes : Form
    {
        List<PrescribeItems> bill_items = new List<PrescribeItems>();
        PrescribeItems items = new PrescribeItems();
        Drug drug = new Drug();
        Prescribe Prescribe = new Prescribe();
        int index;
        public Prescripes()
        {

            Prescribe prescribe = new Prescribe();
            InitializeComponent();
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from N in db.Doctors
                              select new { name1 = N.FirstName, name2 = N.LastName }).ToList();
                var doctor_names = new List<string>();
                foreach (var doctor in result)
                {
                    doctor_names.Add(doctor.name1 + " " + doctor.name2);
                }
                cmbDocName.DataSource = doctor_names;

                try
                {
                    cmbDocName.SelectedIndex = 0;
                }
                catch
                {
                }
            }
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from N in db.Drugs
                              select new ComboItem { Name = N.Name }).ToList();
                List<string> drug_names = new List<string>();
                foreach (var item in result)
                {
                    drug_names.Add(item.Name);
                }
                cmb_MedName.DataSource = drug_names;
                try
                {
                    cmb_MedName.SelectedIndex = 0;
                }
                catch
                {
                }
            }
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from N in db.Drugs
                              select new ComboItem { Name = N.Name }).ToList();
                List<string> drug_names = new List<string>();
                foreach (var item in result)
                {
                    drug_names.Add(item.Name);
                }
                cmb_MedName.DataSource = drug_names;

                try
                {
                    cmb_MedName.SelectedIndex = 0;
                }
                catch
                {
                }
            }
        }

        private void Prescripes_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = string.Format("Date:-{0}", DateTime.Now);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount :" + label9.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dgv_SellMed);
            label9.Text = "LE.00";
            txtTotalPrice.Text = "0";
            dgv_SellMed.DataSource = 0;
            for (int i = 0; i < bill_items.Count; i++)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    Drug drug = new Drug();
                    var value = bill_items[i].DrugName;
                    drug = db.Drugs.Where(d => d.Name == value).FirstOrDefault();
                    drug.Quantity -= bill_items[i].NumberOfUnits;
                    db.SaveChanges();
                }
            }
            using (PharmacyEntities db = new PharmacyEntities())
            {
                for (int i = 0; i < bill_items.Count; i++)
                {
                    Bill bill = new Bill();
                    bill.DrugName = bill_items[i].DrugName;
                    bill.NumberOfUnits = bill_items[i].NumberOfUnits;
                    bill.Price = Decimal.Parse(bill_items[i].Price);
                    bill.TotalPrice = Decimal.Parse(bill_items[i].TotalPrice);
                    bill.ExpiryDate = DateTime.Parse(bill_items[i].ExpiryDate);
                    bill.PharmacistName = cmbDocName.Text;
                    bill.CustomerName = txtCustomName.Text;
                    bill.SellingDate =Convert.ToString( DateTime.Now);
                    db.Bills.Add(bill);
                }
                db.SaveChanges();
            }
            bill_items.Clear();
            PopulateDataGridView();
            using (PharmacyEntities db = new PharmacyEntities())
            {
                drug = db.Drugs.Where(d => d.Name == (string)cmb_MedName.SelectedValue).FirstOrDefault();
            }
            available_quantityLabel.Text = "Available Quantity : " + drug.Quantity;
            txtNo.Text = "";
            txtCustomName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Purchase.Enabled = true;
                if (txtNo.Text == "")
                {
                    label12.Visible = true;
                }


                bool IsValid = true;
                for (int i = 0; i < bill_items.Count; ++i)
                {
                    if (bill_items[i].DrugName == txtMedName.Text)
                    {
                        using (PharmacyEntities db = new PharmacyEntities())
                        {
                            var value = bill_items[i].DrugName;
                            drug = db.Drugs.Where(d => d.Name == value).FirstOrDefault();
                        }
                        if (bill_items[i].NumberOfUnits + int.Parse(txtNo.Text) <= drug.Quantity &&bill_items[i].NumberOfUnits + int.Parse(txtNo.Text)>=1)
                        {
                            bill_items[i].NumberOfUnits += int.Parse(txtNo.Text);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Quantity", "Out of Range Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        decimal new_total = decimal.Parse(bill_items[i].Price) * bill_items[i].NumberOfUnits;
                        bill_items[i].TotalPrice = new_total.ToString();
                        IsValid = false;
                        break;
                    }
                }
                if (IsValid)
                {

                    PrescribeItems items = new PrescribeItems();
                    items.DrugName = txtMedName.Text;
                    items.NumberOfUnits = int.Parse(txtNo.Text);
                    using (PharmacyEntities db = new PharmacyEntities())
                    {
                        drug = db.Drugs.Where(d => d.Name == items.DrugName).FirstOrDefault();
                        if (items.NumberOfUnits > drug.Quantity &&int.Parse(txtNo.Text)==0)
                        {
                            MessageBox.Show("Invalid Quantity", "Out of Range Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    items.Price = txtPrice.Text;
                    items.TotalPrice = txtTotalPrice.Text;
                    items.ExpiryDate = dtpExpiry.Text;
                    bill_items.Add(items);
                    using (PharmacyEntities db = new PharmacyEntities())
                    {
                        bool valid = true;
                        for (int i = 0; i < bill_items.Count; i++)
                        {
                            if (bill_items[i].NumberOfUnits > drug.Quantity)
                            {
                                bill_items.RemoveAt(i);
                                valid = false;
                            }
                            if (bill_items[i].NumberOfUnits==0)
                            {
                                bill_items.RemoveAt(i);
                                valid = false;
                                label12.Visible = true;
                               
                            }
                        }

                    }

                }
                PopulateDataGridView();


            }
            catch
            {

            }
        }
        void PopulateDataGridView()
        {
            dgv_SellMed.AutoGenerateColumns = false;
            dgv_SellMed.DataSource = bill_items.Select(b => new { b.DrugName, b.NumberOfUnits, b.Price, b.ExpiryDate, b.TotalPrice }).ToList();
            decimal total_price = 0;
            for (int i = 0; i < bill_items.Count; i++)
            {
                decimal price = decimal.Parse(bill_items[i].TotalPrice);
                total_price += price;
            }
            label9.Text = $"LE : {total_price}";
        }

        private void cmbDocName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            bill_items.RemoveAt(index);
            PopulateDataGridView();
            MessageBox.Show("Removed Successfully");
        }

        private void dgv_SellMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbNameMed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cmb_MedName_SelectedValueChanged(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                drug = db.Drugs.Where(d => d.Name == (string)cmb_MedName.SelectedValue).FirstOrDefault();
                available_quantityLabel.Text = "Available Quantity : " + drug.Quantity;
            }
            txtMedName.Text = drug.Name;
            txtPrice.Text = Convert.ToString(drug.sellingPrice);
            dtpExpiry.Text = Convert.ToString(drug.ExpiryDate);
            txtNo.Text = "1";

        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isControl = char.IsControl(e.KeyChar);
            bool isDigit = char.IsDigit(e.KeyChar);
            
            bool isHyphen = e.KeyChar == '-';
            bool isFirstChar = (sender as TextBox).Text.Length == 0;

            bool isAllowed =
                isControl ||
                isDigit ||
                (isHyphen && isFirstChar);

            if (!isAllowed)
            {
                e.Handled = true;
            }

            label12.Visible = false;

        }

        private void txtCustomName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal total_price = drug.sellingPrice * int.Parse(txtNo.Text);
                txtTotalPrice.Text = Convert.ToString(total_price);
            }
            catch
            {

            }
        }

        private void txtCustomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SellMed_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                btn_Remove.Enabled = true;
                    if (dgv_SellMed.CurrentRow.Index != -1)
                    {
                    items.DrugName = Convert.ToString(dgv_SellMed.CurrentRow.Cells["DrugName"].Value);
                    index = bill_items.FindIndex(i => i.DrugName == items.DrugName);
                    }
            }
            catch
            {
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class ComboItem
    {
        public string Name;
    }
    class PrescribeItems
    {
        public string DrugName;
        public int NumberOfUnits;
        public string Price;
        public string TotalPrice;
        public string ExpiryDate;
    }

}
