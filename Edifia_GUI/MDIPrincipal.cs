﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edifia_GUI
{
    public partial class MDIPrincipal : Form
    {
        TimeSpan horaEntrada = new TimeSpan();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // fecha y hora del sistema
            this.Text = "Edifia - Menu Principal      " + DateTime.Now.ToString();

            // tiempo de sesion 
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            horaEntrada = DateTime.Now.TimeOfDay;
            lblUsuario.Text = $"Usuario: {clsCredenciales.Usuario?.ToString() ?? "Desconocido"}";
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentoMan01 objDepartamentoMan01 = new DepartamentoMan01();
            objDepartamentoMan01.MdiParent = this;
            objDepartamentoMan01.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoMan01 objDMantenimientoMan01 = new MantenimientoMan01();
            objDMantenimientoMan01.MdiParent = this;
            objDMantenimientoMan01.Show();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void visitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitaMan01 objVisitaMan01 = new VisitaMan01();
            objVisitaMan01.MdiParent = this;
            objVisitaMan01.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado objfrmEmpleado = new frmEmpleado();
            objfrmEmpleado.MdiParent = this;
            objfrmEmpleado.Show();
        }

        private void habitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabitanteMan01 objHabitanteMan01 = new HabitanteMan01();
            objHabitanteMan01.MdiParent = this;
            objHabitanteMan01.Show();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void habitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadosExcel frmExcel = new frmListadosExcel();
            frmExcel.MdiParent = this;
            frmExcel.Show();
        }
    }
}
