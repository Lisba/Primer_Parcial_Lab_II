﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Kwit_E_Mart
{
    public partial class DetallesVentaEmpleadoForm : Form
    {
        #region Constructors
        public DetallesVentaEmpleadoForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga los datos al dataGridViewDetalleCompra, los label y oculta las filas id y cantidad al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetallesVentaEmpleadoForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewDetalleCompra.DataSource = null;
            this.dataGridViewDetalleCompra.DataSource = VentasEmpleadoForm.VentaSeleccionada.ListaProductosVenta;
            this.dataGridViewDetalleCompra.Columns["Id"].Visible = false;
            this.dataGridViewDetalleCompra.Columns["Cantidad"].Visible = false;
            this.lblFechaHoraVenta.Text = VentasEmpleadoForm.VentaSeleccionada.Date.ToString();
            this.lblPrecioTotalCompraDetalles.Text = VentasEmpleadoForm.VentaSeleccionada.PrecioTotal.ToString();
            this.lblClienteDetalleCompra.Text = VentasEmpleadoForm.VentaSeleccionada.Cliente.SayNameLastname(VentasEmpleadoForm.VentaSeleccionada.Cliente.Nombre, VentasEmpleadoForm.VentaSeleccionada.Cliente.Apellido);
            this.lblEmpleadoDetalleCompra.Text = VentasEmpleadoForm.VentaSeleccionada.Empleado.SayNameLastname(VentasEmpleadoForm.VentaSeleccionada.Empleado.Nombre, VentasEmpleadoForm.VentaSeleccionada.Empleado.Apellido);
        }
        #endregion
    }
}
