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
    public partial class Medicine : Form
    {
        Drug drug = new Drug();
        DrugManufactruer manufactruer = new DrugManufactruer();
        public Medicine()
        {
            InitializeComponent();
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from M in db.DrugManufactruers
                              select new { M.Name }).ToList();
                cmbBoxName_Man.DataSource = result;
                cmbBoxName_Man.DisplayMember = "Name";
                cmbBoxName_Man.ValueMember = "Name";
                try
                {
                    cmbBoxName_Man.SelectedIndex = 0;
                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbl_ExpiryDate.Visible = false;
        }

        private void txtBoxNameDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxISSNMed.Text.Length != 8 || txtBoxISSNMed.Text == "")
                {
                    lbl_ISSN.Visible = true;
                }
                if (txtBoxNameMed.Text == "")
                {
                    lbl_MedName.Visible = true;
                }
                if (txtBoxQty.Text == "")
                {
                    lbl_Qty.Visible = true;
                }
                if (txtBoxBuyPri.Text == "")
                {
                    lbl_BuyPrice.Visible = true;
                }
                if (txtBoxSellPri.Text == "" || Decimal.Parse(txtBoxSellPri.Text) < Decimal.Parse(txtBoxBuyPri.Text))
                {
                    lbl_SellPrice.Visible = true;
                }
                if (dtpProDate.Value.Year >= dtpExpDate.Value.Year)
                {
                    lbl_ExpiryDate.Visible = true;
                }



            int DrugIssn;
            if (Int32.TryParse(txtBoxISSNMed.Text.Trim(), out DrugIssn))
            {
                drug.ISSN = DrugIssn;
            }
            drug.Name = txtBoxNameMed.Text.Trim();
            drug.ProductionDate = DateTime.Parse(dtpProDate.Text.Trim());
            drug.ExpiryDate = DateTime.Parse(dtpExpDate.Text.Trim());
            drug.Quantity = int.Parse(txtBoxQty.Text.Trim());
            drug.sellingPrice = Decimal.Parse(txtBoxSellPri.Text.Trim());
            drug.BuyingPrice = Decimal.Parse(txtBoxBuyPri.Text.Trim());

            }
            catch 
            {
                
            }
            using (PharmacyEntities db = new PharmacyEntities())
            {

                try
                {
                if (drug.ID == 0)//Insert
                {
                    manufactruer = db.DrugManufactruers.Where(m => m.Name == (string)cmbBoxName_Man.SelectedValue).FirstOrDefault();
                    drug.ManufactruerID = manufactruer.ID;
                    db.Drugs.Add(drug);
                }
                else //Update
                {
                    manufactruer = db.DrugManufactruers.Where(m => m.Name == (string)cmbBoxName_Man.SelectedValue).FirstOrDefault();
                    drug.ManufactruerID = manufactruer.ID;
                    drug.DrugManufactruer = manufactruer;
                    db.Entry(drug).State = EntityState.Modified;
                }
                db.SaveChanges();
                MessageBox.Show("Saved Successfully");
                }
                catch
                {
                    
                }
            }
            try
            {
                Clear();
                PopulateDataGridView();
            }
            catch
            {

            }
        }
    
        void Clear()
        {
            txtBoxISSNMed.Text = txtBoxNameMed.Text = txtBoxSellPri.Text = txtBoxBuyPri.Text = txtBoxQty.Text = "";
            button_add.Text = "Add";
            button_delete.Enabled = false;
            try
            {
                cmbBoxName_Man.SelectedIndex = 0;
            }
            catch
            {

            }
            drug.ID = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void PopulateDataGridView()
        {
            dgv_Medicine.AutoGenerateColumns = false;
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result= (from D in db.Drugs
                              join P in db.DrugManufactruers
                              on D.ManufactruerID equals P.ID
                              select new { D.ISSN,name1= D.Name, D.ExpiryDate, D.ProductionDate, D.Quantity, D.sellingPrice, D.BuyingPrice,P.Name}).ToList();
                dgv_Medicine.DataSource = result;
            }
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void dgv_Medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Medicine_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Medicine.CurrentRow.Index != -1)
            {
                drug.ISSN = Convert.ToInt32(dgv_Medicine.CurrentRow.Cells["ISSN"].Value);
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    drug = db.Drugs.Where(x => x.ISSN == drug.ISSN).FirstOrDefault();
                    txtBoxISSNMed.Text =Convert.ToString(drug.ISSN);
                    txtBoxNameMed.Text = drug.Name;
                    dtpExpDate.Text = Convert.ToString(drug.ExpiryDate);
                    dtpProDate.Text = Convert.ToString(drug.ProductionDate);
                    txtBoxSellPri.Text = Convert.ToString(drug.sellingPrice);
                    txtBoxBuyPri.Text = Convert.ToString(drug.BuyingPrice);
                    txtBoxQty.Text = Convert.ToString(drug.Quantity);
                    cmbBoxName_Man.Text=drug.DrugManufactruer.Name;
                }
                button_add.Text = "Update";
                button_delete.Enabled = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Delete this Medicine", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var entry = db.Entry(drug);
                    if (entry.State == EntityState.Detached)
                        db.Drugs.Attach(drug);
                        db.Drugs.Remove(drug);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtBoxISSNMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) == 8)
                {
                    e.Handled = true;
                }
            }
            lbl_ISSN.Visible = false;
        }
        private void txtBoxNameMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_MedName.Visible = false;
        }

        private void txtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_Qty.Visible = false;
           
        }

        private void txtBoxBuyPri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBuyPri_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_BuyPrice.Visible = false;
        }

        private void txtBoxSellPri_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_SellPrice.Visible = false;
        }

        private void cmbBoxName_Man_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ManufactruerName.Visible = false;
        }

        private void dtpProDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
