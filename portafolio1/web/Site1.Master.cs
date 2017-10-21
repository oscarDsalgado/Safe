using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            menuTecnico.Visible = false;
            menuTrabajador.Visible = false;
            menuIngeniero.Visible = false;
            menuSupervisor.Visible = false;
            menuMedico.Visible = false;
            menuCliente.Visible = false;

            string user = Session["login"].ToString();
            if (Session["login"]==null)
            {
                Response.Redirect("Log_in.aspx");
            }
            else { 
                 string rol = Session["tipo"].ToString();
                 switch (rol)
                 {
                     case "Tecnico":
                         menuTecnico.Visible = true;
                         break;
                     case "Trabajador":
                         menuTrabajador.Visible = true;
                         break;
                     case "Supervisor":
                         menuSupervisor.Visible = true;
                         break;
                     case "Medico":
                         menuMedico.Visible = true;
                         break;
                     case "Ingeniero":
                         menuIngeniero.Visible = true;
                         break;
                     case "Cliente":
                         menuCliente.Visible = true;
                         break;



                 }
                
            
            }


            Label1.Text = Session["tipo"].ToString();
            Label2.Text = Session["login"].ToString();
            
            
        }

        protected void Cerrar_sesion(object sender, EventArgs e)
        {
            Session["login"] = "";
            Session["tipo"] = "";
            Response.Redirect("Log_in.aspx");
        }
    }
}