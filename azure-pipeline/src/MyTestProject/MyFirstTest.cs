using NUnit.Framework;
using MyProject;

namespace MyTestProject
{
   [TestFixture]
    public class MyFirstTest
    {
        MyTestLibraryClass myTestLibraryClass;
        [SetUp]
        public void SetUp()
        {
            myTestLibraryClass = new MyTestLibraryClass();
        }

        [Test]
        public void MyFirstTest_GetValue_ReturnStringValue(){
            
            var result = myTestLibraryClass.GetValue();

            Assert.AreEqual("My string for test", result);
        }
    }
}