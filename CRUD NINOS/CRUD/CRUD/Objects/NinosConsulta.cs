using CRUD.BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD.Objects
{
    internal class NinosConsultas
    {
        private ConexionMySql mConexion;
        private List<Ninos> mNinos;

        public NinosConsultas()
        {
            mConexion = new ConexionMySql();
            mNinos = new List<Ninos>();
        }

        public bool agregarNinos(Ninos ninos)
        {
            string INSERT = "INSERT INTO Datos_Ninos (Nombre_n, Fecha_nacimiento, Tipo_sangre, Ciudad_nacimiento, Identificacion_acudiente, Telefono, Direccion_n, EPS, Identificador_Jardin)" +
                            " values (@Nombre_n, @Fecha_nacimiento, @Tipo_sangre, @Ciudad_nacimiento, @Identificacion_acudiente, @Telefono, @Direccion_n, @EPS, @Identificador_Jardin);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre_n", ninos.Nombre_n));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_nacimiento", ninos.Fecha_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Tipo_sangre", ninos.Tipo_sangre));
            mCommand.Parameters.Add(new MySqlParameter("@Ciudad_nacimiento", ninos.Ciudad_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Identificacion_acudiente", ninos.Identificacion_acudiente));
            mCommand.Parameters.Add(new MySqlParameter("@Telefono", ninos.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@Direccion_n", ninos.Direccion_n));
            mCommand.Parameters.Add(new MySqlParameter("@EPS", ninos.EPS));
            mCommand.Parameters.Add(new MySqlParameter("@Identificador_Jardin", ninos.Identificador_Jardin));
            try
            {
                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                mConexion.closeConexion();
            }
        }

        public bool modificarNinos(Ninos ninos)
        {
            string UPDATE = "UPDATE Datos_Ninos " +
        "SET Nombre_n = @Nombre_n, " +
        "Fecha_nacimiento = @Fecha_nacimiento, " +
        "Tipo_sangre = @Tipo_sangre, " +
        "Ciudad_nacimiento = @Ciudad_nacimiento, " +
        "Identificacion_acudiente = @Identificacion_acudiente, " +
        "Telefono = @Telefono, " +
        "Direccion_n = @Direccion_n, " +
        "EPS = @EPS, " +
        "Identificador_Jardin = @Identificador_Jardin " +
        "WHERE Registro = @registro";


            MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre_n", ninos.Nombre_n));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_nacimiento", ninos.Fecha_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Tipo_sangre", ninos.Tipo_sangre));
            mCommand.Parameters.Add(new MySqlParameter("@Ciudad_nacimiento", ninos.Ciudad_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Identificacion_acudiente", ninos.Identificacion_acudiente));
            mCommand.Parameters.Add(new MySqlParameter("@Telefono", ninos.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@Direccion_n", ninos.Direccion_n));
            mCommand.Parameters.Add(new MySqlParameter("@EPS", ninos.EPS));
            mCommand.Parameters.Add(new MySqlParameter("@Identificador_Jardin", ninos.Identificador_Jardin));
            Console.WriteLine("Consulta SQL: " + mCommand.CommandText);

            try
            {
                return mCommand.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Error de MySQL - Número: " + ex.Number);
                Console.WriteLine("Mensaje: " + ex.Message);
                return false;
            }
            finally
            {
                mConexion.closeConexion();
            }
        }

        public bool eliminarNinos(Ninos ninos)
        {
            string DELETE = "DELETE FROM Datos_Ninos WHERE Registro = @registro";
            MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@registro", ninos.Registro));
            return mCommand.ExecuteNonQuery() > 0;
        }

        
       public List<Ninos> consultarNinos(string filtro)
        {
            string CONSULTA = "SELECT * FROM Datos_Ninos";

            MySqlDataReader mReader = null;
            Ninos nino;
            List<Ninos> ninos = new List<Ninos>();

            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "Registro LIKE '%" + filtro + "%' OR " +
                        "Nombre_n LIKE '%" + filtro + "%' OR " +
                        "Fecha_nacimiento LIKE '%" + filtro + "%' OR " +
                        "Tipo_sangre LIKE '%" + filtro + "%' OR " +
                        "Ciudad_nacimiento LIKE '%" + filtro + "%' OR " +
                        "Identificacion_acudiente LIKE '%" + filtro + "%' OR " +
                        "Telefono LIKE '%" + filtro + "%' OR " +
                        "Direccion_n LIKE '%" + filtro + "%' OR " +
                        "EPS LIKE '%" + filtro + "%' OR " +
                        "Identificador_Jardin LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    nino = new Ninos();
                    nino.Registro = mReader.GetInt32("Registro");
                    nino.Nombre_n = mReader.GetString("Nombre_n");
                    nino.Fecha_nacimiento = mReader.GetString("Fecha_nacimiento");
                    nino.Tipo_sangre = mReader.GetString("Tipo_sangre");
                    nino.Ciudad_nacimiento = mReader.GetString("Ciudad_nacimiento");
                    nino.Identificacion_acudiente = mReader.GetInt32("Identificacion_acudiente");
                    nino.Telefono = mReader.GetInt32("Telefono");
                    nino.Direccion_n = mReader.GetString("Direccion_n");
                    nino.EPS = mReader.GetString("EPS");
                    nino.Identificador_Jardin = mReader.GetInt32("Identificador_Jardin");
                    ninos.Add(nino);
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

            return ninos;
        }

    }
}
