﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaaa.Clases
{
    internal class Caulas
    {
        public void mostrarAulas(DataGridView tablaAulas)
        {
			try
			{
                string query = "select * from aulas";
                Cconexion objConex = new Cconexion();
                tablaAulas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConex.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                        string disponible = "disponible".ToString();

                tablaAulas.DataSource = dt;
                objConex.cerrarConexion();
			}
			catch (Exception ex)
			{
                MessageBox.Show("No se mostraron las aulas correctamente: " + ex.ToString());
			}
        }
        public List<string> obtenerDisponible()
        {
            List<string> valores = new List<string>();
            try
            {
                using (MySqlConnection conexion = new Cconexion().establecerConexion())
                {
                    string query = "SHOW COLUMNS FROM aulas WHERE Field = 'disponible'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string enumString = reader["Type"].ToString();
                                enumString = enumString.Substring(5, enumString.Length - 6);
                                valores = enumString.Split(',').Select(v => v.Trim('\'')).ToList();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener valores de sexo: " + ex.Message);
            }
            return valores;
        }
        public void agregarAula(TextBox nombre, TextBox capacidad)
        {
            try
            {
                Cconexion objConex = new Cconexion();
                string query = "insert into aulas (nombre, capacidad)"+
                    "values ('"+ nombre.Text+ "','"+capacidad.Text+"');";
                MySqlCommand cmd = new MySqlCommand(query, objConex.establecerConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se guardo correctamente el aula");
                while (reader.Read())
                {

                }
                objConex.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron las aulas correctamente: " + ex.ToString());
            }
        }
        public void seleccionarAula(DataGridView tablaAulas, TextBox id, TextBox nombre, TextBox capacidad, ComboBox disponible)
        {
            try
            {
                id.Text = tablaAulas.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaAulas.CurrentRow.Cells[1].Value.ToString();
                capacidad.Text = tablaAulas.CurrentRow.Cells[2].Value.ToString();
                disponible.Text = tablaAulas.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron las aulas correctamente: " + ex.ToString());
            }
        }
        public void modificarAula(TextBox id,TextBox nombre, TextBox capacidad, ComboBox disponible)
        {
            try
            {
                Cconexion objConex = new Cconexion();
                string query = "update aulas set nombre='" + nombre.Text + "', capacidad ='" + capacidad.Text + "', disponible ='" + disponible.Text + "' where id ='"+ id.Text+"';";
                MySqlCommand cmd = new MySqlCommand(query, objConex.establecerConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se modifico correctamente el aula");
                while (reader.Read())
                {

                }
                objConex.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron las aulas correctamente: " + ex.ToString());
            }
        }
        public void eliminarAula(TextBox id)
        {
            try
            {
                Cconexion objConex = new Cconexion();
                string query = "delete from aulas where id ='" + id.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, objConex.establecerConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se elimino correctamente el aula");
                while (reader.Read())
                {

                }
                objConex.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron las aulas correctamente: " + ex.ToString());
            }
        }
    }
}