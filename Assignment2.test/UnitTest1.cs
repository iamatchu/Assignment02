using NUnit.Framework;
using Assignment02;

namespace Assignment2.test
{
    /* Unit test case to verify all the methods written in the rectangle class.
     */ 
    [TestFixture]
    public class UnitTest1
    {
        Rectangle rectTest = new Rectangle();
        /*  Test case 1 for the length, width, height and volume methods.
         */
        [Test]
        public void GettingLengthTestCase1()
        {
            int a = 1;
            int result = rectTest.Getlength();
            Assert.AreEqual(result, a);
        }
        [Test]
        public void SettingLengthTestCase1()
        {
            int a = 4;
            int result = rectTest.Setlength(a); 
            Assert.AreEqual(result, a); //assertion
        }

        [Test]
        public void GettingWidthTestCase1()
        {
            int b = 1;
            int result = rectTest.Getwidth(); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void SettingWidthTestCase1()
        {
            int b = 4;
            int result = rectTest.Setwidth(b); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void GettingHeightTestCase1()
        {
            int b = 1;
            int result = rectTest.GetHeight(); //act
            Assert.AreEqual(result, b); //assert
        }

        [Test]
        public void SettingHeightTestCase1()
        {
            int b = 4;
            int result = rectTest.SetHeight(b); 
            Assert.AreEqual(result, b); //assert
        }

        [Test]
        public void RectangleVolumeTestCase1()
        {
            int a = 2, b = 3, c = 3;
            rectTest.Setlength(a);
            rectTest.Setwidth(b);
            rectTest.SetHeight(3);
            int result = rectTest.GetRectangleVolume(); 
            Assert.AreEqual(result, 18); //assert
        }

        /*  Test case 2 for the length, width, height and volume methods.
         */
        [Test]
        public void GettingLengthTestCase2()
        {
            int a = 1;
            int result = rectTest.Getlength();
            Assert.AreEqual(result, a);
        }
        [Test]
        public void SettingLengthTestCase2()
        {
            int a = 6;
            int result = rectTest.Setlength(a);
            Assert.AreEqual(result, a); //assert
        }

        [Test]
        public void GettingWidthTestCase2()
        {
            int b = 1;
            int result = rectTest.Getwidth(); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void SettingWidthTestCase2()
        {
            int b = 6;
            int result = rectTest.Setwidth(b); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void GettingHeightTestCase2()
        {
            int b = 1;
            int result = rectTest.GetHeight(); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void SettingHeightTestCase2()
        {
            int b = 6;
            int result = rectTest.SetHeight(b); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void RectangleVolumeTestCase2()
        {
            int a = 3, b = 3, c = 3;
            rectTest.Setlength(a);
            rectTest.Setwidth(b);
            rectTest.SetHeight(c);
            int result = rectTest.GetRectangleVolume(); 
            Assert.AreEqual(result, 27); //assertion
        }

        /*  Test case 3 for the length, width, height and volume methods.
         */
        [Test]
        public void GettingLengthTestCase3()
        {
            int a = 1;
            int result = rectTest.Getlength();
            Assert.AreEqual(result, a);
        }
        [Test]
        public void SettingLengthTestCase3()
        {
            int a = 5;
            int result = rectTest.Setlength(a);
            Assert.AreEqual(result, a); //assertion
        }

        [Test]
        public void GettingWidthTestCase3()
        {
            int b = 1;
            int result = rectTest.Getwidth(); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void SettingWidthTestCase3()
        {
            int b = 5;
            int result = rectTest.Setwidth(b); 
            Assert.AreEqual(result, 4); //assertion
        }

        [Test]
        public void GettingHeightTestCase3()
        {
            int b = 1;
            int result = rectTest.GetHeight(); 
            Assert.AreEqual(result, b); //assertion
        }

        [Test]
        public void SettingHeightTestCase3()
        {
            int b = 5;
            int result = rectTest.SetHeight(b); 
            Assert.AreEqual(result, b); //assert
        }

        [Test]
        public void RectangleVolumeTestCase3()
        {
            int a = 4, b = 4, c = 4;
            rectTest.Setlength(a);
            rectTest.Setwidth(b);
            rectTest.SetHeight(c);
            int result = rectTest.GetRectangleVolume(); 
            Assert.AreEqual(result, 64); //assert
        }

    }
}