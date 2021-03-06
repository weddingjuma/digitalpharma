﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace digitalPharma
{
    public partial class frmSubMenuForSalesMan : Form
    {

        public frmSubMenuForSalesMan()
        {
            InitializeComponent();
        }
        private void frmSubMenu_Load(object sender, EventArgs e)
        {

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmDataBase))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new FrmDataBase();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width + 2, 50);
            newForm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmSupplier))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmSupplier();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width + 10, 50);
            newForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmProductCategory))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmProductCategory();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width, 50);
            newForm.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmPurchase))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmPurchase();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width, 20);
            newForm.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            /*foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmSale))
                {
                    form.Activate();
                    return;
                }
            }*/

            Form newForm = new frmSale();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width, 50);
            newForm.Show();
        }

        private void frmSubMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                if (MessageBox.Show("Are You Sure To Exit?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.SuppressKeyPress = true;
                }

            }
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmReportAll))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmReportAll();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            newForm.Location = new Point(sub.Width, 50);
            newForm.Show();
        }

        private void pbPurchase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmPrintReceipt))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmPrintReceipt();
            newForm.MdiParent = this.MdiParent;
            frmSubMenu sub = new frmSubMenu();
            //newForm.Location = new Point(sub.Width, 50);
            newForm.Show();
        }


        /*private void btnBill_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBill))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmBill();
            newForm.MdiParent = this.MdiParent;
            newForm.Show();  
        }
        */

    }
}
