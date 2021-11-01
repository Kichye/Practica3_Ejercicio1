
namespace Ventanilla.GUI
{
    partial class MAten
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
            this.lbl_tiem = new System.Windows.Forms.Label();
            this.lbl_cl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tiem
            // 
            this.lbl_tiem.AutoSize = true;
            this.lbl_tiem.Location = new System.Drawing.Point(245, 91);
            this.lbl_tiem.Name = "lbl_tiem";
            this.lbl_tiem.Size = new System.Drawing.Size(34, 13);
            this.lbl_tiem.TabIndex = 11;
            this.lbl_tiem.Text = "Texto";
            // 
            // lbl_cl
            // 
            this.lbl_cl.AutoSize = true;
            this.lbl_cl.Location = new System.Drawing.Point(245, 58);
            this.lbl_cl.Name = "lbl_cl";
            this.lbl_cl.Size = new System.Drawing.Size(34, 13);
            this.lbl_cl.TabIndex = 10;
            this.lbl_cl.Text = "Texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente atendido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiempo de espera en la cola:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(168, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MAten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_tiem);
            this.Controls.Add(this.lbl_cl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "MAten";
            this.Text = "Tiempo de espera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_tiem;
        public System.Windows.Forms.Label lbl_cl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}