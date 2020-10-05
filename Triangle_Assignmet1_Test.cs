using System;
using Triangle_Assignment_1;
using NUnit.Framework;

namespace Triangle_Assignment1_test
{
     [TestFixture]
    public class Triangle_Assignmet1_Test
    {
        //testcase1 : (a+b=c)
       
        [Test]
        public void AnalyzeTriangle_Input5and5and10_outputNotTri()
        {
            //Arrange 
            int x = 5;
            int y = 5;
            int z = 10;
            string expected = "Not Triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        //testcase 2:( a+c<=b)
        [Test]
        public void AnalyzeTriangle_Input5and11and5_outputNotTri()
        {
            //Arrange 
            int x = 5;
            int y = 11;
            int z = 5;
            string expected = "Not Triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //testcase 3: (b+c<=a)
        [Test]
        public void AnalyzeTriangle_Input7and3and3_outputNotTri()
        {
            //Arrange 
            int x = 7;
            int y = 3;
            int z = 3;
            string expected = "Not Triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //testcase 4: (a+b>c && a+c>b && b+c>a) && (a=b=c)
        [Test]
        public void AnalyzeTriangle_Input666_outputEquilateral()
        {
            //Arrange 
            int x = 6;
            int y = 6;
            int z = 6;
            string expected = "Equilateral triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //test case 5: (a+b>c && a+c>b && b+c>a) && (a=b && b!=c && a!=c)
        
       [Test]
        public void AnalyzeTriangle_Input335_outputIsosceles()
        {
            //Arrange 
            int x = 3;
            int y = 3;
            int z = 5;
            string expected = "Isosceles triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //test case 6: (a+b>c && a+c>b && b+c>a) && (a!=b && b=c && a!=c)
       
        [Test]
        public void AnalyzeTriangle_Input533_outputIsosceles()
        {
            //Arrange 
            int x = 5;
            int y = 3;
            int z = 3;
            string expected = "Isosceles triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //test case 7: (a+b>c && a+c>b && b+c>a) && (a!=b && b!=c && a=c)
        [Test]
        public void AnalyzeTriangle_Input353_outputIsosceles()
        {
            //Arrange 
            int x = 3;
            int y = 5;
            int z = 3;
            string expected = "Isosceles triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //test case8: (a+b>c && a+c>b && b+c>a) && (a!=b)&& (b!=c)&&(a!=c)
        [Test]
        public void AnalyzeTriangle_Input345_outputScalene()
        {
            //Arrange 
            int x = 3;
            int y = 4;
            int z = 5;
            string expected = "Scalene triangle";

            //Act
            string actual = TriangleSolver.Analyze(x, y, z);
            //Assert
            Assert.AreEqual(expected, actual);
        }
      


    }
}
