using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string btn1, btn2, btn3, btn4;
        [TestMethod]

        //SQA_BeeHotel_prueba2
        //SE DESPEGARA EL MENU PRINCIPAL CON LAS HERRAMIENTAS Y SERVICIOS A REALIZAR
        public void TestMethod1()
        {
            string result = EstandaresdeCalidad_Hotel.negocio.Form_Dashboard.something();
            Assert.AreEqual("Algo", result);
        }

        [TestMethod]
        //DEPENDENCIA
        //FUNCIONALIDAD DE ACCIONES
        public void TestingLoginTrue()
        {
            btn1 = "cliente";
            btn2 = "Agregar";
            btn3 = "Modificar";
            btn4 = "Eliminar";
        }
    }
}

