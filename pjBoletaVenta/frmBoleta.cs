using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjBoletaVenta
{
    public partial class frmBoleta : Form
    {
        // Variables globales
        int num;

        Boleta objB = new();

        public frmBoleta()
        {
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objB.DescripcionProducto = cboProducto.Text;
            txtPrecio.Text = objB.DeterminaPrecio().ToString("C"); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                // Capturar los datos
                CapturaDatos();

                // Determinar los cálculos de la aplicación
                double precio = objB.DeterminaPrecio();
                double importe = objB.Calculalmporte();

                // Imprimir el detalle de la venta
                ImprimirDetalle(precio, importe);

                // Imprimir el total acumulado
                lblTotal.Text = DeterminaTotal().ToString("C");
            }
            else
                MessageBox.Show($"El error se encuentra en {Valida()}");
        }
        // Método que calcula el monto acumulado de los importes
        private double DeterminaTotal()
        {
            double total = 0;
            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += double.Parse(lvDetalle.Items[i].SubItems[3].Text);
            }
            return total;
        }

        private void ImprimirDetalle(double precio, double importe)
        {
            ListViewItem fila = new(objB.CantidadComprada.ToString());
            fila.SubItems.Add(objB.DescripcionProducto);
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(importe.ToString("0.00"));
            lvDetalle.Items.Add(fila);
        }

        // Capturar los datos del formulario
        private void CapturaDatos()
        {
            objB.NumeroBoleta = int.Parse(lblNumero.Text);
            objB.NombreCliente = txtCliente.Text;
            objB.DireccionCliente = txtDireccion.Text;
            objB.CedulaCliente = txtCedula.Text;
            objB.FechaRegistro = DateTime.Parse(txtFecha.Text);
            objB.DescripcionProducto = cboProducto.Text;
            objB.CantidadComprada = int.Parse(txtCantidad.Text);
        }

        // Validar el ingreso de datos
        private string Valida()
        {
            if(txtCliente.Text.Trim().Length == 0)
            {
                txtCliente.Focus();
                return "nombre del cliente";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "dirección del cliente";
            }
            else if (txtCedula.Text.Trim().Length == 0)
            {
                txtCedula.Focus();
                return "cédula del cliente";
            }
            else if(cboProducto.SelectedIndex == -1)
            {
                cboProducto.Focus();
                return "descripción del producto";
            }
            else if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "cantidad comprada";
            }
            return "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new(lblNumero.Text);
            fila.SubItems.Add(txtFecha.Text);
            fila.SubItems.Add(TotalCantidad().ToString());
            fila.SubItems.Add(DeterminaTotal().ToString("C"));
            lvEstadisticas.Items.Add(fila);
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtCliente.Clear();
            txtDireccion.Clear();
            txtCedula.Clear();
            cboProducto.Text = "(Seleccione)";
            txtPrecio.Clear();
            txtCantidad.Clear();
            lvDetalle.Items.Clear();
        }

        // Total de productos por boleta
        private int TotalCantidad()
        {
            int total = 0;
            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += int.Parse(lvDetalle.Items[i].SubItems[0].Text);
            }
            return total;
        }
    }
}
