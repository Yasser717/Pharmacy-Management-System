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
    public partial class DrugManufactrueer : Form
    {
        DrugManufactruer drugManufactruer = new DrugManufactruer();
        DrugManufactruerPhoneNumber drugManufactruerPhoneNumber = new DrugManufactruerPhoneNumber();
        public DrugManufactrueer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtboxname.Text == "")
                {
                    lbl_name.Visible = true;
                }
                if (txtboxemail.Text == "" || !(txtboxemail.Text.Contains('@')))
                {
                    lbl_Email.Visible = true;
                }
                if (txtboxaddress.Text == "")
                {
                    lbl_Address.Visible = true;
                }
                if (txtboxphone1.Text == "" || txtboxphone1.Text.Length != 11 || txtboxphone1.Text[0] != '0' || txtboxphone1.Text[1] != '1')
                {
                    lbl_Phone.Visible = true;
                }

                drugManufactruer.Name = txtboxname.Text.Trim();
                drugManufactruer.Address = txtboxaddress.Text.Trim();

                drugManufactruer.Email = txtboxemail.Text.Trim();
                drugManufactruerPhoneNumber.PhoneNumber1 = txtboxphone1.Text.Trim();
                if (drugManufactruerPhoneNumber.PhoneNumber2 != " ")
                {
                    drugManufactruerPhoneNumber.PhoneNumber2 = txtboxphone2.Text.Trim();
                }
                else
                {
                    drugManufactruerPhoneNumber.PhoneNumber2 = " ";
                }
            }
            catch
            {

            }
            using (PharmacyEntities db = new PharmacyEntities())
            {
                try
                {
                    if (drugManufactruer.ID == 0 && drugManufactruerPhoneNumber.ID == 0)//Insert
                {
                    db.DrugManufactruerPhoneNumbers.Add(drugManufactruerPhoneNumber);
                    drugManufactruer.DrugManufactruerPhoneNumbers.Add(drugManufactruerPhoneNumber);
                    drugManufactruerPhoneNumber.DrugManufactruer= drugManufactruer;
                    db.DrugManufactruers.Add(drugManufactruer);
                }
                else //Update
                {
                    db.Entry(drugManufactruer).State = EntityState.Modified;
                    db.Entry(drugManufactruerPhoneNumber).State = EntityState.Modified;
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
            txtboxname.Text = txtboxaddress.Text = txtboxemail.Text = txtboxphone1.Text = txtboxphone2.Text = "";
            add.Text = "Add";
            delete.Enabled = false;
            drugManufactruer.ID = 0;
            drugManufactruerPhoneNumber.ID = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void PopulateDataGridView()
        {
            dgv_DrugManufactruer.AutoGenerateColumns = false;
            using (PharmacyEntities db = new PharmacyEntities())
            {
                var result = (from D in db.DrugManufactruers
                              join P in db.DrugManufactruerPhoneNumbers
                              on D.ID equals P.DrugManufactruerID
                              select new { D.ID, D.Name, D.Address, D.Email, P.PhoneNumber1, P.PhoneNumber2}).ToList();
                dgv_DrugManufactruer.DataSource = result;
            }
            remove_null();
        }
        public void remove_null()
        {
            //for (int i = 0; i < dgv_DrugManufactruer .Rows.Count - 1; i++)
            //{
            //    if (dgv_DrugManufactruer.Rows[i].Cells[5].Value.ToString() == null)
            //    {
            //        dgv_DrugManufactruer.Rows[i].Visible = false;
            //    }
            //}
        }

        private void dgv_DrugManufactruer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DrugManufactruer_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_DrugManufactruer.CurrentRow.Index != -1)
            {
               drugManufactruer.ID = Convert.ToInt32(dgv_DrugManufactruer.CurrentRow.Cells["ID"].Value);
                //doctorPhoneNumber.ID = Convert.ToInt32()
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    drugManufactruer = db.DrugManufactruers.Where(x => x.ID == drugManufactruer.ID).FirstOrDefault();
                    txtboxname.Text = drugManufactruer.Name;
                    txtboxaddress.Text = drugManufactruer.Address;
                    txtboxemail .Text = drugManufactruer.Email;   
                    drugManufactruerPhoneNumber = db.DrugManufactruerPhoneNumbers.Where(x => x.DrugManufactruerID == drugManufactruer.ID).FirstOrDefault();
                    txtboxphone1.Text = drugManufactruerPhoneNumber.PhoneNumber1;
                    txtboxphone2.Text = drugManufactruerPhoneNumber.PhoneNumber2;
                }
                add.Text = "Update";
                delete.Enabled = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure to Delete this ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    var entry = db.Entry(drugManufactruer);
                    if (entry.State == EntityState.Detached)
                        db.DrugManufactruers.Attach(drugManufactruer);
                    DrugManufactruerPhoneNumber drugManufactruerPhoneNumber = db.DrugManufactruerPhoneNumbers.Where(x => x.DrugManufactruerID ==drugManufactruer.ID).FirstOrDefault();
                    db.DrugManufactruerPhoneNumbers.Remove(drugManufactruerPhoneNumber);
                    db.DrugManufactruers.Remove(drugManufactruer);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void txtboxphone1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxphone2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtboxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
            lbl_name.Visible = false;
        }

        private void DrugManufactrueer_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Email.Visible = false;
        }

        private void txtboxaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Address.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
