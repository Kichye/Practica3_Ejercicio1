
namespace Ventanilla.GUI
{
    partial class MsjAgre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.lbl_cl = new System.Windows.Forms.Label();
            this.lbl_mov = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente formado en Cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de llegada:";
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Location = new System.Drawing.Point(245, 98);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(34, 13);
            this.lbl_tur.TabIndex = 5;
            this.lbl_tur.Text = "Texto";
            // 
            // lbl_cl
            // 
            this.lbl_cl.AutoSize = true;
            this.lbl_cl.Location = new System.Drawing.Point(245, 124);
            this.lbl_cl.Name = "lbl_cl";
            this.lbl_cl.Size = new System.Drawing.Size(34, 13);
            this.lbl_cl.TabIndex = 6;
            this.lbl_cl.Text = "Texto";
            // 
            // lbl_mov
            // 
            this.lbl_mov.AutoSize = true;
            this.lbl_mov.Location = new System.Drawing.Point(245, 157);
            this.lbl_mov.Name = "lbl_mov";
            this.lbl_mov.Size = new System.Drawing.Size(34, 13);
            this.lbl_mov.TabIndex = 7;
            this.lbl_mov.Text = "Texto";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(245, 187);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(34, 13);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "Texto";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(178, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MsjAgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_mov);
            this.Controls.Add(this.lbl_cl);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MsjAgre";
            this.Text = "Mensaje Imporatante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Label lbl_tur;
        public System.Windows.Forms.Label lbl_cl;
        public System.Windows.Forms.Label lbl_mov;
        private System.Windows.Forms.Button button1;
    }
}