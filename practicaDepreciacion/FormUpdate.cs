using AppCore.IServices;
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
    public partial class FormUpdate : Form

       
    {


        public IActivoServices activoServices { get; set; }
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void Btnsi_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo()
            {
                Id = int.Parse(lblId.Text),
                Nombre = txtNombre.Text,
                Valor = float.Parse(txtvalor.Text),
                VidaUtil = int.Parse(txtVutil.Text),
                ValorResidual = float.Parse(txtVResidual.Text)
            };

            activoServices.Update(activo, activo.Id);
            Dispose();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
