using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace web
{
    public partial class Formulario_web5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipo"].ToString() != "Supervisor")
            {
                Response.Redirect("Home.aspx");
            }
            mensajeSI.Visible = false;
            mensajeNO.Visible = false;

            ServiceReference1.wsa1SoapClient ws= new ServiceReference1.wsa1SoapClient();
            
        
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area: " + Comboarea.Text + ", fecha: " + Calendar1.SelectedDate + ", tema: " + Txttema.Text + ", expositor: " + txtExpositor.Text + ", asistencia: " + TxtAsistencia.Text + ", empresa: " + Comboemp.Text + ",tipocap: " + Combotipocap.Text + "", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ServiceReference1.wsa1SoapClient wf = new ServiceReference1.wsa1SoapClient();

            if (wf.GuardarCapacitacion(Comboarea.Text, Calendar1.SelectedDate, Txttema.Text, txtExpositor.Text, Int32.Parse(TxtAsistencia.Text), Comboemp.Text, Int32.Parse(Combotipocap.Text)))
            {
                //MessageBox.Show("Logrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mensajeSI.Visible = true;

            }
            else {
                //MessageBox.Show("No logrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeNO.Visible = true;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}