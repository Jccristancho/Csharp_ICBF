using CRUD.BD;
using CRUD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Objects
{
    internal class JardinConsultas
    {
        private ConexionMySql mConexion;
        private List<Jardin> mJardines;

        public JardinConsultas()
        {
            mConexion = new ConexionMySql();
            mJardines = new List<Jardin>();
        }

        public bool agregarJardin(Jardin mJardin)
        {
            string INSERT = "INSERT INTO Registro_Jardin (Nombre_jardin, Direccion_j, Estado)" +
                            " values (@nombre, @direccion, @estado);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", mJardin.Nombre_jardin));
            mCommand.Parameters.Add(new MySqlParameter("@direccion", mJardin.Direccion_j));
            mCommand.Parameters.Add(new MySqlParameter("@estado", mJardin.Estado));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool modificarJardin(Jardin mJardin)
        {
            string UPDATE = "UPDATE Registro_Jardin " +
                            "SET Nombre_jardin = @nombre, " +
                            "Direccion_j = @direccion, " +
                            "Estado = @estado " +
                            "WHERE Identificador_Jardin = @id";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", mJardin.Nombre_jardin));
            mCommand.Parameters.Add(new MySqlParameter("@direccion", mJardin.Direccion_j));
            mCommand.Parameters.Add(new MySqlParameter("@estado", mJardin.Estado));
            mCommand.Parameters.Add(new MySqlParameter("@id", mJardin.Identificador_Jardin));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool eliminarJardin(Jardin mJardin)
        {
            string DELETE = "DELETE FROM Registro_Jardin WHERE Identificador_Jardin = @id";
            MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@id", mJardin.Identificador_Jardin));
            return mCommand.ExecuteNonQuery() > 0;
        }

        public List<Jardin> consultarJardines(string filtro)
        {
            string CONSULTA = "SELECT * FROM Registro_Jardin";

            MySqlDataReader mReader = null;
            Jardin mJardin;

            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "Identificador_Jardin LIKE '%" + filtro + "%' OR " +
                        "Nombre_jardin LIKE '%" + filtro + "%' OR " +
                        "Direccion_j LIKE '%" + filtro + "%' OR " +
                        "Estado LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mJardin = new Jardin();
                    mJardin.Identificador_Jardin = mReader.GetInt16("Identificador_Jardin");
                    mJardin.Nombre_jardin = mReader.GetString("Nombre_jardin");
                    mJardin.Direccion_j = mReader.GetString("Direccion_j");
                    mJardin.Estado = mReader.GetString("Estado");
                    mJardines.Add(mJardin);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mReader?.Close();
                mConexion.closeConexion();
            }

            return mJardines;
        }
    }
}
