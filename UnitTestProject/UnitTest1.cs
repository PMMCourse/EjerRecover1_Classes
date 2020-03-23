using ClassInheritExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DesayunarTrue()
        {
            IPersona person = (IPersona)new Persona();

            Assert.IsTrue(person.IrDesayuno(true));
        }


        [TestMethod]
        public void DesayunarFalse()
        {
            IPersona person = (IPersona)new Persona();

            Assert.IsFalse(person.IrDesayuno(false));
        }


        [TestMethod]
        public void ComprarPan()
        {
            IPersona person = (IPersona)new Persona();

            string mensaje = "";

            try
            {
                person.ComprarPan(3);
            }
            catch (Exception e)
            {

                mensaje = e.Message;
            }

            Assert.AreEqual(mensaje, "Ha comprado 3 piezas de pan");
        }

        //EstudiarCosas(IAsignatura a, int tiempoEstudio, IProfesor p, IAlumno f)

        [TestMethod]
        public void EstudiarCosas()
        {
            IAlumno alum = (IAlumno)new Alumno();
            IProfesor prof = (IProfesor)new Profesor();
            IAsignatura asig = (IAsignatura)new Asignatura(100, "pmm", 40);

            string mensaje = "";

            try
            {
                alum.EstudiarCosas(asig, 3, prof, alum);
            }
            catch (Exception e)
            {

                mensaje = e.Message;
            }

            Assert.AreEqual(mensaje, "Ha estudiado pmm 3 horas");
        }

        [TestMethod]
        public void HacerDeberesDeCosas()
        {
            IAlumno alum = (IAlumno)new Alumno();

            Assert.IsTrue(alum.HacerDeberesDeCosas(true));
        }

        [TestMethod]
        public void EntrarDiscord()
        {
            IAlumno alum = (IAlumno)new Alumno();

            string mensaje = "";

            try
            {
                alum.MeterseEnDiscord(false);
            }
            catch (Exception e)
            {

                mensaje = e.Message;
            }

            Assert.AreEqual(mensaje, "Se puede aprobar todavia");
        }

        [TestMethod]
        public void SuspenderCosas()
        {
            IProfesor prof = (IProfesor)new Profesor();
            IAlumno alum = (IAlumno)new Alumno();

            alum.HacerDeberesDeCosas(false);

            Assert.IsFalse(prof.SuspenderCosas(alum,true));
        }

        [TestMethod]
        public void AprobarCosas()
        {
            IProfesor prof = (IProfesor)new Profesor();

            Assert.IsFalse(prof.AprobarCosas());
        }

        [TestMethod]
        public void DarClasesDeCosas()
        {
            IProfesor prof = (IProfesor)new Profesor();

            string mensaje = "";

            try
            {
                prof.DarClasesDeCosas();
            }
            catch (Exception e)
            {

                mensaje = e.Message;
            }

            Assert.AreEqual(mensaje, "*** Comienza la clase ***");
        }
    }
}
