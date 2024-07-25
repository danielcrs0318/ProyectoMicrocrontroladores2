﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2.Clases
{
    internal class GuardarDatosDHT11
    {
        public double DatoHumedad { get; set; }
        public double DatoCelsius { get; set; }
        public double DatoFahrenheit { get; set; }

        public GuardarDatosDHT11()
        {
            DatoHumedad = 0;
            DatoCelsius = 0;
            DatoFahrenheit = 0;
        }

         public GuardarDatosDHT11(double humedad, double celsius, double fahrenheit)
        {
            DatoHumedad = humedad;
            DatoCelsius = celsius;
            DatoFahrenheit = fahrenheit;
        }
        //metodo para que guarde los datos en la bdd
        public void Guardar()
        {
            //validamos si el campo esta vacio 
            if (DatoHumedad == 0 || DatoCelsius == 0 || DatoFahrenheit == 0)
            {
                MessageBox.Show("Faltan datos del sensor");
            }
            else
            {
                string sql = $"INSERT INTO SensorData (Humedad, Celsius, Fahrenheit) VALUES ({DatoHumedad}, {DatoCelsius}, {DatoFahrenheit});";
                ClaseConexion c = new ClaseConexion();
                if (c.Ejecutar(sql))
                {
                    MessageBox.Show("Registro Guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al guardar el registro");
                }
            }

        }
    }
}
