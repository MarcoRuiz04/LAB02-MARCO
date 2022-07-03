using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class Form1 : Form
    {
        // combo box opcionales
        public static string[] Empleo = new string[]
        {
            "Chofer",
            "Administrativo",
            "TI",
            "Recursos Humanos",
            "Operativo",
            "Gerente",
            "Miselaneo",
            "Principal"
       };


        public static string[] Porcentajes = new string[]
        {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "70%",
            "90%",
            "100%"
        };


        public static string[] EmpleadosApellido = new string[]
        {
            "Ruiz",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };
        public static string[] EmpleadosNombre = new string[]
        {
            "Marco",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };
        public static string[] EmpleadosDomicilio = new string[]
        {
            "Guatuso",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };
        public static string[] EmpleadosDni = new string[]
        {
            "207790520",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };
        public static string[] SocioApellido = new string[]
        {
            "Castro",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };



        public static string[] SocioNombre = new string[]
        {
            "Tatiana",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };



        public static string[] SocioDomicilio = new string[]
        {
            "Venado",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };


        public static string[] SocioDni = new string[]
        {
            "201110111",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
       };



        public static int[] PorcentajeSocios = new int[]
        {
            0,1,2,3,4,5,6,7
        };
        public static int[] PuestoEmpleados = new int[]
        {
            0,1,2,3,4,5,6,7
        };
        
        public static object Empleos { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado oFrmEmpleado = new FrmEmpleado();
            oFrmEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar oFrmModificar = new FrmModificar();
            oFrmModificar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar oFrmElimar = new FrmEliminar();
            oFrmElimar.Show();
        }

        private void nuevoSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocio oFrmSocio = new FrmSocio();
            oFrmSocio.Show();
        }

        private void modificarSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocioModificar oFrmSocioModificar = new FrmSocioModificar();
            oFrmSocioModificar.Show();
        }

        private void eliminarSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocioEliminar oFrmSocioEliminar = new FrmSocioEliminar();
            oFrmSocioEliminar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
