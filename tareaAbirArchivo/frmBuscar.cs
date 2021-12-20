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

namespace tareaAbirArchivo
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        string carpeta = Application.StartupPath + @"\";
        string archivo = @"";



        private void btnCargar_Click(object sender, EventArgs e)
        {
            string carpeta = this.txtCarpeta.Text;
            DirectoryInfo di = new DirectoryInfo(carpeta);

            lstArchivos.Items.Clear();
            foreach(var archivo in di.GetFiles())
            {
                this.lstArchivos.Items.Add(archivo);
            }

            

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //string ubicacion = carpeta + archivo; 

            string ubicacion = @"C:\Users\usuario\Desktop\9no C\2 Quimestre\1 Parcial\Ciencias Naturales\CANCION.txt";
            string leer = File.ReadAllText(ubicacion);
            txtContenido.Text = leer;
        }
    }
}
