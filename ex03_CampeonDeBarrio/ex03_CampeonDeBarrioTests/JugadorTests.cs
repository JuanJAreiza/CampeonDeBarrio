using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex03_CampeonDeBarrio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_CampeonDeBarrio.Tests
{
    [TestClass()]
    public class JugadorTests
    {
        [TestMethod()]
        public void Test_CalculaPromedio()
        {
            //Arrange: Inicializacion de variables
            Jugador jugadorPrueba = new Jugador
            {
                Puntos = 400,
                Campañas = 2,
                Nombre = "Paco"
            };

            //Act: Llamamos la funcion a testear
            float promEsperado = 200;
            float promObtenido = jugadorPrueba.Promedio;

            //Assert: Comprobamos los valores
            Assert.AreEqual(promObtenido, promEsperado);
        }

        [TestMethod()]
        public void Test_IdentificaCampeonUnico()
        {
            //Arrange: Inicializacion de variables
            Jugador[] losJugadores = new Jugador[5]
            {
                new Jugador {Puntos = 150, Campañas = 4, Nombre = "Paco"},
                new Jugador {Puntos = 220, Campañas = 2, Nombre = "Lucia"},
                new Jugador {Puntos = 360, Campañas = 5, Nombre = "Valeria"},
                new Jugador {Puntos = 400, Campañas = 3, Nombre = "Daniel"},
                new Jugador {Puntos = 0, Campañas = 0, Nombre = "Miguel"},
            };

            //Act: Llamamos la funcion a testear
            string nombreEsperado = "Daniel";
            string nombreObtenido = ex03_CampeonDeBarrio.Program.IdentificaCampeon(losJugadores)[0].Nombre;

            //Assert: Comprobamos los valores
            Assert.AreEqual(nombreObtenido, nombreEsperado);
        }

        [TestMethod()]
        public void Test_IdentificaCampeonesEmpatados()
        {
            //Arrange: Inicializacion de variables
            Jugador[] losJugadores = new Jugador[5]
            {
                new Jugador {Puntos = 150, Campañas = 4, Nombre = "Paco"},
                new Jugador {Puntos = 220, Campañas = 2, Nombre = "Lucia"},
                new Jugador {Puntos = 400, Campañas = 3, Nombre = "Valeria"},
                new Jugador {Puntos = 400, Campañas = 3, Nombre = "Daniel"},
                new Jugador {Puntos = 0, Campañas = 0, Nombre = "Miguel"},
            };

            //Act: Llamamos la funcion a testear
            int campeonesEsperados = 2;
            int campeonesObtenidos = ex03_CampeonDeBarrio.Program.IdentificaCampeon(losJugadores).Length;

            //Assert: Comprobamos los valores
            Assert.AreEqual(campeonesObtenidos, campeonesEsperados);

            //Assert.Fail(); Para buscar que directamente falle.
        }
    }
}