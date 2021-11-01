using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventanilla.BO;
using Ventanilla.GUI;

namespace Ventanilla
{
    public partial class Form1 : Form
    {
        Procesos p = new Procesos();
        MsjAgre al = new MsjAgre();
        MAten al2 = new MAten();

        public Form1()
        {
            InitializeComponent();
            txt_turno.Text = "1";
            txt_turno.Enabled = false;
            dgv_tabla.Enabled = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_cliente.Text == "" || cmb_movimiento.Text == "")
            { MessageBox.Show("Ingrese datos Correctos"); }
            else
            {
                p.Nturno = Convert.ToInt32(txt_turno.Text);
                p.Client = txt_cliente.Text;
                p.Movimiento = cmb_movimiento.Text;
                p.Time = Convert.ToString(DateTime.Now);

                if (dgv_tabla.RowCount > 5)
                {
                    ColaLlena();
                }
                else
                {
                    InsertarCola();
                }
            }
            
        }


        public void InsertarCola()
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgv_tabla);
            fila.Cells[0].Value = p.Nturno;
            fila.Cells[1].Value = p.Client;
            fila.Cells[2].Value = p.Movimiento;
            fila.Cells[3].Value = p.Time;
            dgv_tabla.Rows.Add(fila);
            int au = p.Nturno + 1;
            txt_turno.Text = Convert.ToString(au);
            txt();
            alerta1();

            dgv_tabla.Rows[0].Selected = true;
            dgv_tabla.CurrentCell = dgv_tabla.Rows[0].Cells[0];
        }

        public void ColaLlena()
        {
            MessageBox.Show("Cola Llena, atienda a clientes previos");
            txt();
        }

        public void alerta1()
        {
            al.lbl_tur.Text = Convert.ToString(p.Nturno);
            al.lbl_cl.Text = p.Client;
            al.lbl_mov.Text = p.Movimiento;
            al.lbl_time.Text = p.Time;
            al.Show(); 




        }

        public void txt()
        {
            txt_cliente.Text = "";
            cmb_movimiento.SelectedItem = "";
        
        }

        private void btn_atender_Click(object sender, EventArgs e)
        {
            try
            {
                al2.Hide();
                fech();
                dgv_tabla.Rows.Remove(dgv_tabla.CurrentRow);
            }
            catch (Exception)
            { MessageBox.Show("Upps, no hay clientes para atender"); }
            
        }

        public void fech()
        {
                var tiempo = Convert.ToDateTime(p.Time);
                var timeSpan = DateTime.Now - tiempo;

                al2.lbl_cl.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
                al2.lbl_tiem.Text = timeSpan.ToString();
                al2.Show();
        }
    }
}
