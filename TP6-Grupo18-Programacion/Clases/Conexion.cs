﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP6_Grupo18_Programacion.Clases
{
    public class Conexion
    {
        string cadenaConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        // Metodo establecer conexion
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch
            {
                return null;
            }
        }

        // Adapter para cargar GridView
        public SqlDataAdapter ObtenerAdaptador(string consultaSQL)
        {
            // Usando adapter la conexion se cierra sola
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(consultaSQL, ObtenerConexion());
                return adapter;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}