
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Invent_Fashion_Test
{
    [TestClass]
    public class FashionTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(200)]
        [TestCategory("Tax")]
        public void taxCalculation(double Amount)
        {
            double result = Invent_Fashion_Library.InventFashion.calculateHST(Amount);

            Assert.AreEqual(26d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(200)]
        [TestCategory("Tax")]
        public void CalculatingTotal(double Amount)
        {
            double result = Invent_Fashion_Library.InventFashion.totalAmount(Amount);

            Assert.AreEqual(226d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(36)]
        [TestCategory("Size")]
        public void xxsSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("XXS", result);
            
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(37, 37.9)]
        [TestCategory("Size")]
        public void xxsSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("XXS", result);
            Assert.AreSame("XXS", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(38)]
        [TestCategory("Size")]
        public void xsSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("XS", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(39, 39.9)]
        [TestCategory("Size")]
        public void xsSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("XS", result);
            Assert.AreSame("XS", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(40)]
        [TestCategory("Size")]
        public void sSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("S", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(41, 41.9)]
        [TestCategory("Size")]
        public void sSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("S", result);
            Assert.AreSame("S", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(42)]
        [TestCategory("Size")]
        public void mSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("M", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(43, 43.9)]
        [TestCategory("Size")]
        public void mSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("M", result);
            Assert.AreSame("M", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(44)]
        [TestCategory("Size")]
        public void lSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("L", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(45, 45.9)]
        [TestCategory("Size")]
        public void lSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("L", result);
            Assert.AreSame("L", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(46)]
        [TestCategory("Size")]
        public void xlSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("XL", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(47, 47.9)]
        [TestCategory("Size")]
        public void xlSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("XL", result);
            Assert.AreSame("XL", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(48)]
        [TestCategory("Size")]
        public void xxlSize(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("XXL", result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(49, 49.9)]
        [TestCategory("Size")]
        public void xxlSizeMultipleInput(double size, double sizeTwo)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            string resultTwo = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
            Assert.AreSame("XXL", result);
            Assert.AreSame("XXL", resultTwo);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(50)]
        [TestCategory("Size")]
        public void sizeEqual50(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("XXL", result);


        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(33)]
        [TestCategory("Size")]
        public void sizeBelow36(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);
          
            Assert.AreSame("Sorry Enter valid size between 36 to 50", result);
            

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(51)]
        [TestCategory("Size")]
        public void sizeAbove50(double size)
        {
            string result = Invent_Fashion_Library.InventFashion.sizeCalculator(size);

            Assert.AreSame("Sorry Enter valid size between 36 to 50", result);


        }

    }
}