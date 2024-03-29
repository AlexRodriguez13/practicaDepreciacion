﻿using AppCore.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Form1 : Form
    {
        IActivoServices activoServices;
        public Form1(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

    

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual=double.Parse(txtValorR.Text),
                    VidaUtil= int.Parse(txtVidaU.Text)
                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(txtVidaU.Text) || String.IsNullOrEmpty(txtValorR.Text))
            {
              
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txtValor.Text = String.Empty;
            this.txtValorR.Text = String.Empty;
            this.txtVidaU.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormUpdate frmupdate = new FormUpdate();
            frmupdate.activoServices = activoServices;
            frmupdate.lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmupdate.txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmupdate.txtvalor.Text = /*float.Parse*/(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            frmupdate.txtVResidual.Text = /*decimal.Parse*/(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            frmupdate.txtVutil.Text = /*int.Parse*/(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            frmupdate.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = activoServices.Read();
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //activoIds = activos.Select(x => x.Id).ToList();

            if (dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("No se encontro el archivo");
                return;
            }
            activoServices.Delete((int)dataGridView1.CurrentRow.Cells[0].Value);
            
            
               
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = activoServices.Read();
        }

        private void txtValorR_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

