using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace CollectionExtendLib.UnitTests
{
    [TestClass]
    public class ArrayLibraryTests
    {
        [TestMethod]
        public void IsNumber_SByte_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<sbyte>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Byte_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<byte>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Short_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<short>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_UShort_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<ushort>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Int_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<int>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_UInt_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<uint>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Long_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<long>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_ULong_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<ulong>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Float_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<float>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Double_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<double>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Decimal_ReturnsTrue()
        {
            bool result = ArrayLibrary.IsNumber<decimal>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Bool_ReturnsFalse()
        {
            bool result = ArrayLibrary.IsNumber<bool>();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumber_Char_ReturnsFalse()
        {
            bool result = ArrayLibrary.IsNumber<char>();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Stringify_Numbers_ReturnsCorrectString()
        {
            double[] array = new double[] { 1.2, 0.8, 3.4, 2.5 };

            string result = array.Stringify();
            bool res = (result == "[1,2 0,8 3,4 2,5]");
            if (res == false) { res = (result == "[1.2 0.8 3.4 2.5]"); }

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Stringify_NonNumbers_ReturnsCorrectString()
        {
            bool[] array = new bool[] { true, false, true, true };

            string result = array.Stringify();

            Assert.AreEqual("[True False True True]", result);
        }

        [TestMethod]
        public void Average_Numbers_ReturnsCorrectValue()
        {
            short[] array = new short[] { 4, 3, 7, 14 };

            short result = array.Average();

            Assert.AreEqual((short)7, result);
        }

        [TestMethod]
        public void Average_NonNumbers_DoesntCrash()
        {
            bool[] array = new bool[] { true, false, true, true };

            bool result = array.Average();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void Max_Numbers_ReturnsCorrectValue()
        {
            int[] array = new int[] { 4, 3, 7, 14 };

            int result = array.Max();

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Max_NonNumbers_DoesntCrash()
        {
            bool[] array = new bool[] { true, false, true, true };

            bool result = array.Max();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void Min_Numbers_ReturnsCorrectValue()
        {
            double[] array = new double[] { 4.2, 3.1, 7.8, 14.55 };

            double result = array.Min();

            Assert.AreEqual(3.1, result);
        }

        [TestMethod]
        public void Min_NonNumbers_DoesntCrash()
        {
            char[] array = new char[] { 'a', 'b', 'e' };

            char result = array.Min();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void CountDuplicates_ReturnsCorrectValue()
        {
            double[] array = new double[] { 4.2, 4.2, 3.1, 3.1, 7.8, 14.55 };

            int result = array.CountDuplicates();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountValue_ReturnsCorrectValue()
        {
            double[] array = new double[] { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            int result = array.CountValue(3.1);

            Assert.AreEqual(3, result);
        }
        
        [TestMethod]
        public void CopyWithoutDuplicates_ReturnsCorrectList()
        {
            double[] array = new double[] { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            double[] newList = array.CopyWithoutDuplicates();
            int result = newList.Length;

            Assert.AreEqual(3, result);
            Assert.AreEqual(6, array.Length);
        }

        [TestMethod]
        public void Fill_RefillsList()
        {
            double[] array = new double[] { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            array.Fill(5.5);

            for(int element=0; element< array.Length; element++)
            {
                Assert.AreEqual(5.5, array[element]);
            }            
        }

        [TestMethod]
        public void Insert_InsertsIntoList()
        {
            double[] array = new double[] { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            array.Insert(2, 10, 5.5);
            //array.Insert(2, 5,'a'); // This actually works, 'a' will be cast to a double value of 97

            int result = array.Length;

            Assert.AreEqual(6, result);
            for (int element = 2; element < 2+10; element++)
            {
                if (element < array.Length)
                {
                    Assert.AreEqual(5.5, array[element]);
                }
                else return;
            }
        }
    }
}
