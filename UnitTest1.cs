using NUnit.Framework;

namespace PruebasUnitarias
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerificarEnvioEmail()
        {
            //string resultado = GoodDriving.Controllers.IniciarSesionController.SendEmail("hernandezmahechaocsar0@gmail.com", "token");
            string resultado = GoodDriving.Controllers.IniciarSesionController.SendEmail("hernandezmahechaocsar0@gmail.com", "token");
            Assert.AreEqual(resultado, "ok");
        }

        [Test]
        public void VerificarCodificacion()
        {
            //string resultado = GoodDriving.Controllers.IniciarSesionController.SendEmail("hernandezmahechaocsar0@gmail.com", "token");
            string resultado = GoodDriving.Controllers.IniciarSesionController.codifica("oscar123");
            Assert.AreEqual(resultado, "EC448927EBDDBBA76F9CC251082A4001DB2130268C1E48FD5698A2E2E7157D1A");
        }
        [Test]
        public void VerificarEnvioPrueba()
        {
            string resultado = GoodDriving.Controllers.TutorController.SendEmail("1234567890", "aronjsanchez12@gmail.com");
            Assert.AreEqual(resultado, "ok");
        }
    }
}