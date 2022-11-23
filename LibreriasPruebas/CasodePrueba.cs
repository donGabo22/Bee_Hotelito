using EstandaresdeCalidad_Hotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibreriasPruebas
{
    [TestClass]
    public class CasodePrueba
    {
        //SQA_BeeHotel: Autenticaci�n de usuario
       //deberia retornar la entrada de datos 
      //de manera exitosa , sino abortaria la conexion
        [TestMethod]
        public void SQA_prueba1_a()
        {
            string usuario = "admin";
            string contrase�a = "1234";
            //listo preparacion
            //ejecucion
            FrmLogin frm = new FrmLogin();
            frm.validacion(usuario, contrase�a);
                //fin
        }
        //SQA_BeeHotel: Autenticaci�n de usuario
        //DEPENDENCIA: ACCESO AL SISTEMA
        //
        public void SQA_prueba1_b()
        {
            string usuario = "admin";
            string contrase�a = "1234";
            //listo preparacion
            //ejecucion
            FrmLogin frm = new FrmLogin();
            Assert.AreEqual(true, frm.validacion(usuario, contrase�a));
            
            

            //

        }



    }
}
