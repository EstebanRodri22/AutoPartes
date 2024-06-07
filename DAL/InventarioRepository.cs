using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InventarioRepository:BaseDatos
    {
        OracleCommand command;
        public string GenerarConsecutivo(string tabla, string columna)
        {
            int ultimoConsecutivo = ObtenerUltimoConsecutivo(tabla, columna);
            int nuevoConsecutivo = ultimoConsecutivo + 1;
            return nuevoConsecutivo.ToString(); // Retorna el nuevo consecutivo como string
        }

        private int ObtenerUltimoConsecutivo(string tabla, string columna)
        {
            int ultimoConsecutivo = 0;

            AbrirConexion();
            // Consulta para obtener el último consecutivo
            string sql = $"SELECT MAX(CAST({columna} AS INT)) from {tabla}";

            using (command = new OracleCommand(sql, Connection))
            {
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    ultimoConsecutivo = Convert.ToInt32(result);
                }
            }

            CerrarConexion();   
            return ultimoConsecutivo;
        }

        // Métodos específicos que llaman al método genérico
     

        public string registrarInventario(InventarioAutomovil inventario, string procedureName)
        {
            string nuevoEstado = GenerarConsecutivo("administrador.estado_inventario", "ID_EstadoInventario");
            string nuevoRegistro = GenerarConsecutivo("administrador.inventario_automovil", "ID_registro");
            

            try
            {
                AbrirConexion();

                using (command = new OracleCommand(procedureName, Connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    command.Parameters.Add("p_id_registro", OracleDbType.Varchar2).Value = nuevoRegistro;
                    command.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = inventario.placa;
                    command.Parameters.Add("P_ID_EstadoInventario", OracleDbType.Varchar2).Value = nuevoEstado;
                    command.Parameters.Add("P_piezas_recuperadas", OracleDbType.Int32).Value = inventario.estadoInventario.PiezaRecuperadas;
                    command.Parameters.Add("P_Estado_desmontaje", OracleDbType.Varchar2).Value = inventario.estadoInventario.EstadoDesmontaje;

                    command.ExecuteNonQuery();

                    return $"se registro el inventario corectamente ";
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Error al registrar el inventario " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

    }
}
