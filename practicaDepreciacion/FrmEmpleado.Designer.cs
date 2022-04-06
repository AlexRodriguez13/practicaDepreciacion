
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.gbacciones = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbdatos.SuspendLayout();
            this.gbacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(32, 202);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 24;
            this.lblestado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(89, 195);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(121, 20);
            this.txtestado.TabIndex = 23;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(89, 144);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(121, 20);
            this.txtempleado.TabIndex = 22;
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Location = new System.Drawing.Point(18, 151);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(54, 13);
            this.lblempleado.TabIndex = 21;
            this.lblempleado.Text = "Empleado";
            // 
            // cmbcodigo
            // 
            this.cmbcodigo.FormattingEnabled = true;
            this.cmbcodigo.Location = new System.Drawing.Point(89, 94);
            this.cmbcodigo.Name = "cmbcodigo";
            this.cmbcodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbcodigo.TabIndex = 20;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(32, 102);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 19;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registro Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.lblNombre);
            this.gbdatos.Controls.Add(this.lblcodigo);
            this.gbdatos.Controls.Add(this.textBox1);
            this.gbdatos.Controls.Add(this.cmbcodigo);
            this.gbdatos.Controls.Add(this.lblempleado);
            this.gbdatos.Controls.Add(this.lblestado);
            this.gbdatos.Controls.Add(this.txtempleado);
            this.gbdatos.Controls.Add(this.txtestado);
            this.gbdatos.Location = new System.Drawing.Point(22, 70);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(265, 234);
            this.gbdatos.TabIndex = 28;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(6, 28);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(184, 19);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(6, 76);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 31;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(184, 76);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 32;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // gbacciones
            // 
            this.gbacciones.Controls.Add(this.btnsave);
            this.gbacciones.Controls.Add(this.btnclean);
            this.gbacciones.Controls.Add(this.btndelete);
            this.gbacciones.Controls.Add(this.btnmod);
            this.gbacciones.Location = new System.Drawing.Point(22, 310);
            this.gbacciones.Name = "gbacciones";
            this.gbacciones.Size = new System.Drawing.Size(265, 115);
            this.gbacciones.TabIndex = 33;
            this.gbacciones.TabStop = false;
            this.gbacciones.Text = "Acciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 234);
            this.dataGridView1.TabIndex = 34;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbacciones);
            this.Controls.Add(this.gbdatos);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            this.gbacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.GroupBox gbacciones;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}