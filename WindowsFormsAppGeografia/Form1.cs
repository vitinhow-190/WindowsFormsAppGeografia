using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGeografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblEstados.Text = cboEstados.Items.Count.ToString();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            string est = cboEstados.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                cboSuldeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSuldeste.Focus();
            }
            else if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboNorte.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNorte.Focus();
            }
            else if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                cboNordeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNordeste.Focus();
            }
            else if (est == "SC" | est == "RS" | est == "PR")
            {
                cboSul.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSul.Focus();
            }
            else if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                cboCentro.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboCentro.Focus();
            }

            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblCentro.Text = cboCentro.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblSuldeste.Text = cboSuldeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();

            cboCentro.Sorted = true;
            cboEstados.Sorted = true;
            cboNordeste.Sorted = true;
            cboNorte.Sorted = true;
            cboSuldeste.Sorted = true;
            cboSul.Sorted = true;

            cboEstados.ResetText();

            btnEstados.Visible = false;
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboEstados.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
                lblNorte.Text = cboNorte.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNorte.Visible = false;
            }
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                cboEstados.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNordeste.Visible = false;
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            string est = cboCentro.SelectedItem.ToString();
            if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                cboEstados.Items.Add(cboCentro.SelectedItem.ToString());
                cboCentro.Items.Remove(cboCentro.SelectedItem.ToString());
                cboCentro .ResetText();
                lblCentro.Text = cboCentro.Items.Count.ToString() ;
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnCentro.Visible = false;
            }
        }

        private void btnSuldeste_Click(object sender, EventArgs e)
        {
            string est = cboSuldeste.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                cboEstados.Items.Add(cboSuldeste.SelectedItem.ToString());
                cboSuldeste.Items.Remove(cboSuldeste.SelectedItem.ToString());
                cboSuldeste .ResetText();
                lblSuldeste.Text = cboSuldeste.Items.Count.ToString();
                lblEstados.Text = cboEstados .Items.Count.ToString();
                cboEstados.Sorted = true;
                btnSuldeste.Visible = false;
            }
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            if (est == "SC" | est == "RS" | est == "PR")
            {
                cboEstados.Items.Add (cboSul.SelectedItem.ToString());
                cboSul.Items.Remove (cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblSul.Text =  cboSul .Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString ();
                cboEstados.Sorted = true ;
                btnSul.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEstados.Visible = false;
            btnNorte.Visible = false;
            btnNordeste.Visible = false;
            btnCentro.Visible = false;
            btnSuldeste.Visible = false;
            btnSul.Visible = false ;
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboEstados.SelectedItem.ToString();
            btnEstados.Visible= false;
            if (est != "")
            {
                btnEstados.Visible = true;
            }
        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            btnNorte.Visible= false;
            if (est != "")
            {
               btnNorte.Visible = true; 
            }
        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            btnNordeste.Visible= false;
            if (est != "")
            {
                btnNordeste.Visible = true;
            }
        }

        private void cboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboCentro.SelectedItem.ToString();
            btnCentro.Visible = false;
            if (est != "")
            {
                btnCentro.Visible = true;
            }
        }

        private void cboSuldeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSuldeste.SelectedItem.ToString();
            btnSuldeste.Visible = false;
            if (est != "")
            {
                btnSuldeste.Visible = true;
            }
        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            btnSul.Visible = false;
            if (est != "")
            {
                btnSul.Visible = true;
            }
        }
    }
}
