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
    public partial class MedicineValidityCheck : Form
    {
        Drug drug = new Drug();
        public MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void cmb_chkMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chkMed.SelectedIndex == 0)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var result = (from D in db.Drugs
                                  join P in db.DrugManufactruers
                                  on D.ManufactruerID equals P.ID
                                  where D.ExpiryDate>=DateTime.Now
                                  select new { D.ISSN, name1 = D.Name, D.ExpiryDate, D.ProductionDate, D.Quantity, D.sellingPrice, D.BuyingPrice, P.Name }).ToList();
                    dgv_chkMed.DataSource = result;
                    label3.Text = "Valid Medicine";
                    label3.ForeColor = Color.Black;
                }

            }else if (cmb_chkMed.SelectedIndex == 1)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var result = (from D in db.Drugs
                                  join P in db.DrugManufactruers
                                  on D.ManufactruerID equals P.ID
                                  where D.ExpiryDate <= DateTime.Now
                                  select new { D.ISSN, name1 = D.Name, D.ExpiryDate, D.ProductionDate, D.Quantity, D.sellingPrice, D.BuyingPrice, P.Name }).ToList();
                    dgv_chkMed.DataSource = result;
                    label3.Text = "Expiry Medicine";
                    label3.ForeColor = Color.Red;
                }

            }
            else if (cmb_chkMed.SelectedIndex == 2)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var result = (from D in db.Drugs
                                  join P in db.DrugManufactruers
                                  on D.ManufactruerID equals P.ID
                                  select new { D.ISSN, name1 = D.Name, D.ExpiryDate, D.ProductionDate, D.Quantity, D.sellingPrice, D.BuyingPrice, P.Name }).ToList();
                    dgv_chkMed.DataSource = result;
                    label3.Text = "";
                }

            }

        }

        private void MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
