using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba;

namespace Prueba.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        
        // [TestMethod]
        // public void LoginTest()
        // {
            // Login met = new Login();
            // Assert.AreEqual(false, met.logearse("david123", "123","1"));
        // }

        [TestMethod()]
        public void RegistroTest()
        {
            Inicio met = new Inicio();
            Assert.AreEqual(false, met.Registro("david123", "david123", "david123@gmail", "123"));
        }

        [TestMethod()]
        public void TransferirTest()
        {
            Transferencias met = new Transferencias();
            string monto = "20"; string fecha = "22/03/2017 8:03:00"; string cuenta = "1"; string cuenta_destino = "A-00002"; string cod_usuario = "1";
            Assert.AreEqual(true, met.Transferir2(monto, fecha, cuenta, cuenta_destino, cod_usuario));
        }

        [TestMethod]
        public void Realizar_CreditoTest()
        {
            Credito met = new Credito();
            string monto = "20"; string descripcion = "Credito Test"; string fecha = "22/03/2017 8:03:00"; string cuenta = "1"; string cuenta_destino = "A-00002"; string cod_usuario = "1";
            Assert.AreEqual(true, met.Realizar_Credito2(monto, descripcion, fecha, cuenta, cuenta_destino, cod_usuario));
        }

        [TestMethod]
        public void Realizar_DebitoTest()
        {
            Debito met = new Debito();
            string monto = "20"; string descripcion = "Debito Test"; string fecha = "22/03/2017 8:03:00"; string cuenta = "1"; string cuenta_destino = "A-00002"; string cod_usuario = "1";
            Assert.AreEqual(true, met.Realizar_Debito2(monto, descripcion, fecha, cuenta, cuenta_destino, cod_usuario));
        }

        [TestMethod]
        public void Pago_ServiciosTest()
        {
            Pago_Servicios met = new Pago_Servicios();
            string monto = "20"; string fecha = "22/03/2017 8:03:00"; string codCuenta = "1"; string codServicio = "3"; string cod_usuario = "1";
            Assert.AreEqual(true, met.Pagar_servicio2(monto, fecha, codCuenta, codServicio, cod_usuario));
        }

        [TestMethod]
        public void Consultar_SaltoTest()
        {
            Consulta_saldo met = new Consulta_saldo();
            string usuario = "3";
            Assert.AreEqual(true, met.Consultar_saldo(usuario));
        }
    }
}


