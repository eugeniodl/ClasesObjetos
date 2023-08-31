using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPruebaAnotaciones
{
    public partial class frmPrueba : Form
    {
        Employee objE = new();
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objE.IdNumber = int.Parse(txtIDNumber.Text);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                objE.FirstName = txtFirstName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                objE.LastName = txtLastName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
