﻿using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Marca;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MultimodeSales.Vistas.Modelos
{
    public partial class EditModelo : Form
    {
        CMarcaBD marca = new CMarcaBD();
        CModelosDB modelo = new CModelosDB();
        private readonly bool Bandera;

        public EditModelo(bool agregar, string idmodelo, string idmarca, string color, string talla, string precioCliente)
        {
            InitializeComponent();
            this.Bandera = agregar;
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCancelar);
            
            LlenarComboBoxMarca();
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (agregar)
            {
                UCBarraSuperior.lbTitle.Text = "Agregar Modelo";
                rbtnAgregarModelo.Text = "Agregar Modelo";
            }
            else
            {
                UCBarraSuperior.lbTitle.Text = "Editar Modelo";
                rbtnAgregarModelo.Text = "Editar Modelo";
                txtIDModelo.Tag = idmodelo;
                txtIDModelo.Text = idmodelo;
                cobxMarca.SelectedValue = idmarca;
                txtColor.Text = color;
                txtTalla.Text = talla;
                txtPrecioCliente.Text = precioCliente;
            }
            barraSuperior();
            
        }
        private void barraSuperior()
        {
            UCBarraSuperior.picMinimize.Click += new EventHandler(minimizedClick);
            UCBarraSuperior.picClose.Click += new EventHandler(closeClick);
            UCBarraSuperior.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.lbTitle.MouseMove += new MouseEventHandler(CBarraSuperior.Release);
            UCBarraSuperior.panelTitle.Width = UCBarraSuperior.lbTitle.Width + 10;
        }
        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("0", "--Elegir Marca--");
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";
        }
        private void BorrarDatos() 
        {
            txtIDModelo.Text = "";
            txtColor.Text = "";
            txtTalla.Text = "";
            txtPrecioCliente.Text = "";
            txtPrecioPublico.Text = "";
            cobxMarca.SelectedIndex = 0;
        }
        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            if (verificarTextosVacios())
            {
                if (verificarCboxMarcaVacio())
                    if (Bandera)
                        agregarModelo();
                    else
                        modificarModelo();
            }  
        }
        private bool verificarTextosVacios()
        {
            if(!string.IsNullOrWhiteSpace(txtIDModelo.Text) && !string.IsNullOrWhiteSpace(txtColor.Text) 
                && !string.IsNullOrWhiteSpace(txtTalla.Text) && !string.IsNullOrWhiteSpace(txtPrecioCliente.Text))
                return true;
            else
            {
                CMsgBox.DisplayWarning("Por favor de rellenar los espacios");
                return false;
            }
        }
        private bool verificarCboxMarcaVacio()
        {
            if (cobxMarca.SelectedIndex != 0)
                return true;
            else
            {
                CMsgBox.DisplayWarning("Por favor de escoger la marca para el modelo");
                return false;
            }
        }
        private void agregarModelo()
        {
            modelo.AgregarModelo(txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, txtPrecioPublico.Text);
            BorrarDatos();
        }
        private void modificarModelo()
        {
            modelo.EditarModelo(txtIDModelo.Tag + "", txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, decimal.Parse(txtPrecioCliente.Text.Trim('$')));
            CMsgBox.DisplayInfo("Modelo editado correctamente");
            BorrarDatos();
            Close();
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPrecioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(sender, e);
        }
        private void txtPrecioPublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(sender, e);
        }
        #region Panel Barras
        private void minimizedClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
        private void EditModelo_Activated(object sender, EventArgs e)
        {
            CBarraSuperior.GetInt = Handle;
        }
        #endregion
    }
}
