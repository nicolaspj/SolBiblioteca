using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBiblioteca
{
    public partial class Paises : System.Web.UI.Page
    {
        Logica.Pais objLogica = new Logica.Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            TraerPaises();
        }
        void TraerPaises()
        {
            
            gvPaises.DataSource = objLogica.TraerTodos();
            gvPaises.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Entidades.Pais objEntidad = new Entidades.Pais();
            objEntidad.Nombre = txtNombre.Text;
            objLogica.Agregar(objEntidad);
            TraerPaises();
        }

        protected void gvPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //evento x cada sel de fila 
            GridViewRow filaSeleccionada = gvPaises.SelectedRow;
            txtNombre.Text = filaSeleccionada.Cells[2].Text;
            lblId.Text = filaSeleccionada.Cells[1].Text;
         }

        protected void btnModif_Click(object sender, EventArgs e)
        {
            Entidades.Pais objEntidad= new Entidades.Pais();
            objEntidad.Id = Convert.ToInt32(lblId.Text);
            objEntidad.Nombre = txtNombre.Text;
            objLogica.Modifica(objEntidad);
            TraerPaises();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        { 
            objLogica.BorrarPais(Convert.ToInt32(lblId.Text));
            TraerPaises();

        }
    }
}