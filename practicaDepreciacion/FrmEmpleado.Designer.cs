
namespace practicaDepreciacion
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.lblempleado = new System.Windows.Forms.Label();
            this.cmbcodigo = new System.Windows.Forms.ComboBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(311, 273);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 24;
            this.lblestado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(372, 266);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(121, 20);
            this.txtestado.TabIndex = 23;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(372, 215);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(121, 20);
            this.txtempleado.TabIndex = 22;
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Location = new System.Drawing.Point(311, 222);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(54, 13);
            this.lblempleado.TabIndex = 21;
            this.lblempleado.Text = "Empleado";
            // 
            // cmbcodigo
            // 
            this.cmbcodigo.FormattingEnabled = true;
            this.cmbcodigo.Location = new System.Drawing.Point(372, 165);
            this.cmbcodigo.Name = "cmbcodigo";
            this.cmbcodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbcodigo.TabIndex = 20;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(307, 173);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 19;
            this.lblcodigo.Text = "Codigo";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.cmbcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.ComboBox cmbcodigo;
        private System.Windows.Forms.Label lblcodigo;
    }
}