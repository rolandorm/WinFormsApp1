﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Clases;

namespace WinFormsApp1.Algoritmos
{
    public class GeneradorAleatorios
    {
        public List<Asignacion> CrearListaOrigen(int puntosTotales, int limiteInferior, int limiteSuperior)
        {
            List<Asignacion> listaAsignacion = new List<Asignacion>();
            for (int i = 0; i < puntosTotales; i++)
            {
                Random aleatorio = new Random();
                Asignacion generador = new Asignacion();
                generador.Latitud = aleatorio.Next(limiteSuperior);
                generador.Longitud = aleatorio.Next(limiteSuperior);
                generador.IdPunto = i;
                generador.Especie = i.ToString();
                generador.Activo = false;

                listaAsignacion.Add(generador);
            }
            return listaAsignacion;
        }
    }
}
