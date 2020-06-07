using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona Juan = new Persona();
            lblPersona.Text = "Nombre: " + Juan.Nombre + " Sexo :" + Juan.Sexo;
        }

        private void btnMostrarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante Jesus = new Estudiante();
            lblEstudiante.Text = "Nombre : " + Jesus.Nombre + " Promedio :" + Jesus.Promedio;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            listBox1.Clear();
            listBox1.View = View.Details;
            listBox1.Columns.Add("Fecha");
            listBox1.Columns.Add("Empezo");
            listBox1.Columns.Add("Termino");
            listBox1.Columns.Add("Horas totales");
            listBox1.Columns.Add("Total a pagar");


            for (int i = 0; i < listBox1.Columns.Count; i++)
            {
                listBox1.Columns[i].Width = -2;
            }
            var fileLines = File.ReadAllLines(@"C:\Users\Wande\Desktop\Daniela.txt");

            for (int i = 0; i + 4 < fileLines.Length; i += 5)
            {
                listBox1.Items.Add(
                    new ListViewItem(new[]
                    {
                fileLines[i],
                fileLines[i + 1],
                fileLines[i + 2],
                fileLines[i + 3],
                fileLines[i + 4]
                    }));
            }

        
            for (int i = 0; i < listBox1.Columns.Count; i++)
            {
                listBox1.Columns[i].Width = -2;
            }

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(@"C:\Users\Wande\Desktop\Recibidor.txt"))
            {
                foreach (ListViewItem item in listBox1.Items)
                {
                    tw.WriteLine(item.Text);
                    for (int a = 1; a <= 4; a++) 
                    {
                        tw.WriteLine(item.SubItems[a].Text);
                    }
                }
            }

        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            listBox1.Clear();
            Estudiante Juanito = new Estudiante();
            ListViewGroup Nombre = new ListViewGroup("Nombres",HorizontalAlignment.Center);
            ListViewGroup Edad = new ListViewGroup("Edad", HorizontalAlignment.Center);
            ListViewGroup Sexo = new ListViewGroup("Sexo", HorizontalAlignment.Center);
            ListViewGroup Estatura = new ListViewGroup("Estatura", HorizontalAlignment.Center);
            ListViewGroup Promedio = new ListViewGroup("Promedio", HorizontalAlignment.Center);
            ListViewGroup Estado = new ListViewGroup("Estado", HorizontalAlignment.Center);
            listBox1.Items.Add(new ListViewItem(Juanito.Nombre, Nombre));
            listBox1.Items.Add(new ListViewItem(Juanito.Edad.ToString(), Edad));
            listBox1.Items.Add(new ListViewItem(Juanito.Sexo.ToString(), Sexo));
            listBox1.Items.Add(new ListViewItem(Juanito.Estatura.ToString(), Estatura));
            listBox1.Items.Add(new ListViewItem(Juanito.Promedio.ToString(), Promedio));
            listBox1.Items.Add(new ListViewItem(Juanito.Estado.ToString(), Estado));
        }
    }
}

