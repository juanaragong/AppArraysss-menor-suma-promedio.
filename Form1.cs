namespace AppArraysss
{
    public partial class Form1 : Form
    {
        string[] nombreAlumno = new string[4];
        double[] calificaciones = new double[4];
        double sumaCalificaciones = 0, promedioGrupo = 0, calificacionmenor = 0;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
           
            for (i = 0; i < nombreAlumno.Length; i++)
            {
                calificaciones[i] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox
                    ("Dame la calificacion del alumno"));

                sumaCalificaciones += calificaciones[i];
                lsbDatos.Items.Add(calificaciones[i].ToString());


                if (calificaciones[i] < calificacionmenor)
                {
                    calificacionmenor = calificaciones[i];
                }
            }
            promedioGrupo = sumaCalificaciones / calificaciones.Length;
            lblPromedio.Text = promedioGrupo.ToString("0.00");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calificacionmenor = calificaciones[0];
            for (i = 0; i < nombreAlumno.Length; i++)
            {
               
                if (calificaciones[i] < calificacionmenor)
                {
                    calificacionmenor = calificaciones[i];
                }

            }
            lblMenor.Text = calificacionmenor.ToString("0.00");
        }
    }
}
