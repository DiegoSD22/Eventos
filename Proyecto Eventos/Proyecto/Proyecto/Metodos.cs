using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


/*Agregar un textbox o similar en el inicio, en el que se pueda poner la ruta de la base de datos
 * con fines de que el profesor pueda poner cualquier base
 
    
    +++++++Revisar el metodo Conectar()+++++++*/

namespace Proyecto
{
    class Metodos
    {
        public static string cad_con = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:/Programacion orientada a eventos/Proyecto Eventos/Proyecto/Proyecto.mdb";
        public static OleDbConnection con;
        public static string estado="A";
        public static string estadou = "U";

        public static OleDbConnection Conectar()
        {

            /*Inicio nuevo = new Inicio();
            if (nuevo.textBox3.Text != null)
            {
                String cad_tex = nuevo.textBox3.Text;
                try
                {

                    con = new OleDbConnection(cad_tex);
                    con.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                }
            }
            else
            {
                String cad_con = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:/Users/daam_/Documents/Proyecto Eventos/Proyecto/Proyecto.mdb";
                try
                {

                    con = new OleDbConnection(cad_con);
                    con.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                }
            }

            return con;*/
            
            try
            {

                con = new OleDbConnection(cad_con);
                con.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            return con;

        }
        public static void Iniciar(String usu, String pass)
        {
           Boolean sesion = false;
           Inicio inicio = new Inicio();
            OleDbConnection ole = new OleDbConnection();
            ole = Conectar();
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd.Connection = ole;            
            cmd.CommandText = "SELECT * FROM usuarios WHERE Usuario='" + usu+"'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string var = reader.GetValue(1).ToString();
                string var2 = reader.GetValue(2).ToString();
                string var3 = reader.GetValue(3).ToString();
                if (usu == var && pass == var2 && estado == var3)
                {


                    sesion = true;
                    Administrador admin = new Administrador();
                    admin.Show();
                }
                else if(usu == var && pass == var2 && estadou == var3)
                {
                   sesion = false;
                    Compras usua = new Compras();
                    usua.Show();
                }
                else
                {
                    MessageBox.Show("No Existe el usuario");
                }

                
            }
            
        }
        

        public static void Borrar(string id)
        {

            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas borrar este registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Delete FROM usuarios WHERE Id=" + id;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Elemento borrado con exito");
            }
        }

        public static void Agregar(string Id,string usuario, string Contrasena, string Estado)
        {

            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas agregar este registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Insert into usuarios VALUES("+Id+","+"'"+usuario+"'"+","+"'"+Contrasena+"'"+","+"'"+Estado+"'"+")";
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Elemento agregado con exito");
            }
        }

        public static void Editar(string Id,string usuario, string Contrasena, string Estado)
        {

            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas cambiar este registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Update usuarios set Usuario=" + "'" + usuario + "'" + "," + "Contrasena=" + "'" + Contrasena + "'" + "," + "Estado=" + "'" + Estado + "'"+"Where Id="+Id;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Elemento agregado con exito");
            }
        }



    }
}
