
namespace Ventanilla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_movimiento = new System.Windows.Forms.ComboBox();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_turno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_atender = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horallegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_movimiento
            // 
            this.cmb_movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_movimiento.FormattingEnabled = true;
            this.cmb_movimiento.Items.AddRange(new object[] {
            "Pago de servicio",
            "Depósito",
            "Retiro",
            "Compra de tiempo aire",
            "Consulta de saldo"});
            this.cmb_movimiento.Location = new System.Drawing.Point(114, 135);
            this.cmb_movimiento.Name = "cmb_movimiento";
            this.cmb_movimiento.Size = new System.Drawing.Size(121, 21);
            this.cmb_movimiento.TabIndex = 0;
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.label2);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Controls.Add(this.txt_turno);
            this.grp_datos.Controls.Add(this.txt_cliente);
            this.grp_datos.Controls.Add(this.cmb_movimiento);
            this.grp_datos.Location = new System.Drawing.Point(28, 12);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(441, 180);
            this.grp_datos.TabIndex = 1;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Datos del Cliente";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(114, 88);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(294, 20);
            this.txt_cliente.TabIndex = 1;
            // 
            // txt_turno
            // 
            this.txt_turno.Location = new System.Drawing.Point(114, 40);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(100, 20);
            this.txt_turno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(490, 45);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(175, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar a Cola";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_atender
            // 
            this.btn_atender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atender.Location = new System.Drawing.Point(490, 93);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(175, 23);
            this.btn_atender.TabIndex = 3;
            this.btn_atender.Text = "Atender en Ventanilla";
            this.btn_atender.UseVisualStyleBackColor = true;
            this.btn_atender.Click += new System.EventHandler(this.btn_atender_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(490, 150);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(175, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salida del Sistema";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turno,
            this.cliente,
            this.tipomov,
            this.horallegada});
            this.dgv_tabla.Location = new System.Drawing.Point(28, 212);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.Size = new System.Drawing.Size(637, 226);
            this.dgv_tabla.TabIndex = 5;
            // 
            // turno
            // 
            this.turno.HeaderText = "No. Turno";
            this.turno.Name = "turno";
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            // 
            // tipomov
            // 
            this.tipomov.HeaderText = "Tipo de Movimiento";
            this.tipomov.Name = "tipomov";
            // 
            // horallegada
            // 
            this.horallegada.HeaderText = "Hora Llegada";
            this.horallegada.Name = "horallegada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_atender);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.grp_datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_movimiento;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_turno;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_atender;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomov;
        private System.Windows.Forms.DataGridViewTextBoxColumn horallegada;
    }
}

