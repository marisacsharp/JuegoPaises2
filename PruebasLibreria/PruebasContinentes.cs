using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_Espa�a()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais espa�a = europa.getPais("Espa�a");
            Assert.IsNotNull(espa�a);
        }
        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            
           
            Assert.ThrowsException<KeyNotFoundException>(
                ()=>europa.getPais("Nueva Zelanda")
                );
        }

    }
}
