using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_Comprobacion_edad
{
    public partial class Form1 : Form
    {
        int edad = 0;
        String diaSemana = "";
        Boolean error;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Recoger el texto del día de la semana
        /// </summary>
        /// <remarks>
        /// Por defecto, el grupo de radioButtons tiene asignado el Lunes como día predeterminado,
        /// por lo que, si el usuario no ha seleccionado otro día, recogemos el día Lunes para 
        /// asignarlo a la variable diaSemana.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            diaSemana = rbLunes.Text;
        }
        /// <summary>
        /// Comrpobaciones de los distintos campos
        /// </summary>
        /// <remarks>
        /// Comprobamos si el texto recogido es mayor de edad, para ello, miramos primero
        /// si hay caracteres introducidos. Si no, enviamos un error al label.
        /// Una vez hecho esto, si es mayor de edad, enviamos sólo el día de la semana,
        /// si no, enviamos que tiene clase y el día de la semana correspondiente.
        /// </remarks>
        /// <param name="sender">Button</param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            //comprobamos los datos recogidos
            if(txtEdad.TextLength == 0)
            {
                lblResultado.Text = "Por favor, introduzca una edad y pulse de nuevo el botón";
            }
            else
            {
                edad = int.Parse(txtEdad.Text);
                if(edad >= 18)
                {
                    lblResultado.Text = string.Format("Hoy es {0}", diaSemana);
                }
                else
                {
                    switch (diaSemana)
                    {
                        case "Sábado":
                            lblResultado.Text = string.Format("Hoy es {0} y no hay clase", diaSemana);
                            break;
                        case "Domingo":
                            lblResultado.Text = string.Format("Hoy es {0} y no hay clase", diaSemana);
                            break;
                        default:
                            lblResultado.Text = string.Format("Hoy es {0} y tienes clase", diaSemana);
                            break;
                    }
                }
            }
            
            



        }
        /// <summary>
        /// Controlamos si se ha introducido texto
        /// </summary>
        /// <remarks>
        /// Si se ha introducido texto, habilitamos el botón de aceptar.
        /// </remarks>
        /// <param name="sender">txtEdad</param>
        /// <param name="e"></param>
        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                txtEdad.Text = "";
                error = true;
            }
            else
            {
                error = false;
            }
            btnAceptar.Enabled = true;
        }


        /// <summary>
        /// cada vez que marcamos un RadioButton distinto, obtenemos el texto del día de la semana
        /// </summary>
        /// <param name="sender">SENDER</param>
        /// <param name="e">PARAM</param>
        private void rbSabado_CheckedChanged(object sender, EventArgs e)
        {
            //TODO, asignr numero de la semana a numSemana.
            diaSemana = ((RadioButton)sender).Text;
            
        }

       
    }
}
