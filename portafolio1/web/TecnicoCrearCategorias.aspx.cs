using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class TecnicoCrearCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BLL.TipoEvaluacionDTO t = new BLL.TipoEvaluacionDTO();


                foreach (var item in t.ListarTipos())
                {
                    ListItem item2 = new ListItem(item.Nombre, item.Id.ToString());
                    DropDownList1.Items.Add(item2);
                }



                GridView1.DataBind();
            }

        }



        protected void rb_Yes_Click(object sender, EventArgs e)
        {
            RadioButton rb_Yes = (RadioButton)sender;
            GridViewRow grid_row = (GridViewRow)rb_Yes.NamingContainer;
            if (((RadioButton)grid_row.FindControl("rb_Yes")).Checked == true)
            {

                System.Windows.Forms.MessageBox.Show("si", grid_row.Cells[1].Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);

            }
        }

        protected void rb_No_Click(object sender, EventArgs e)
        {
            RadioButton rb_Yes = (RadioButton)sender;
            GridViewRow grid_row = (GridViewRow)rb_Yes.NamingContainer;
            if (((RadioButton)grid_row.FindControl("rb_No")).Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("no", grid_row.Cells[1].Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

            string categoria = TextBox1.Text;
            int id = int.Parse(DropDownList1.SelectedItem.Value);
            //BLL.DTOCategoria.AgregarCategoria(categoria, id);

            GridView1.DataBind();





        }
    }
}