using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            dgPersona.DataSource = persona.mostrarRegistro();
            dgPersona.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.cedula = txtcedula.Text;
            p.nombre = txtnombre.Text;
            p.apellido = txtapellido.Text;
            p.fechaNacimiento =Convert.ToDateTime( txtfechanacimiento.Text);
            p.edad =Convert.ToInt32(txtedad.Text);
            p.ciudad = txtciudad.Text;
            if (p.nuevaPersona(p) >= 0)
            {
                msg.Text = "Registro guardado..";
            }
            else {
                msg.Text = "No se pudo guardar el registro...";
            }

        }
    }
}