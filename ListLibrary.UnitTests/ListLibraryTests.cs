using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace ListLibrary.UnitTests
{
    [TestClass]
    public class ListLibraryTests
    {
        [TestMethod]
        public void IsNumber_SByte_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<sbyte>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Byte_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<byte>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Short_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<short>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_UShort_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<ushort>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Int_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<int>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_UInt_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<uint>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Long_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<long>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_ULong_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<ulong>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Float_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<float>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Double_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<double>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Decimal_ReturnsTrue()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<decimal>();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_Bool_ReturnsFalse()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<bool>();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumber_Char_ReturnsFalse()
        {
            bool result = UtilityLibraries.ListLibrary.IsNumber<char>();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Stringify_Numbers_ReturnsCorrectString()
        {
            List<double> list = new List<double> { 1.2, 0.8, 3.4, 2.5 };

            string result = list.Stringify();
            bool res = (result == "[1,2 0,8 3,4 2,5]");
            if (res == false) { res = (result == "[1.2 0.8 3.4 2.5]"); }

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Stringify_NonNumbers_ReturnsCorrectString()
        {
            List<bool> list = new List<bool> { true, false, true, true };

            string result = list.Stringify();

            Assert.AreEqual("[True False True True]", result);
        }

        [TestMethod]
        public void Average_Numbers_ReturnsCorrectValue()
        {
            List<short> list = new List<short> { 4, 3, 7, 14 };

            short result = list.Average();

            Assert.AreEqual((short)7, result);
        }

        [TestMethod]
        public void Average_NonNumbers_DoesntCrash()
        {
            List<bool> list = new List<bool> { true, false, true, true };

            bool result = list.Average();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void Max_Numbers_ReturnsCorrectValue()
        {
            List<int> list = new List<int> { 4, 3, 7, 14 };

            int result = list.Max();

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Max_NonNumbers_DoesntCrash()
        {
            List<bool> list = new List<bool> { true, false, true, true };

            bool result = list.Max();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void Min_Numbers_ReturnsCorrectValue()
        {
            List<double> list = new List<double> { 4.2, 3.1, 7.8, 14.55 };

            double result = list.Min();

            Assert.AreEqual(3.1, result);
        }

        [TestMethod]
        public void Min_NonNumbers_DoesntCrash()
        {
            List<char> list = new List<char> { 'a', 'b', 'e' };

            char result = list.Min();

            // If the function doesn't crash, it's fine
        }

        [TestMethod]
        public void CountDuplicates_ReturnsCorrectValue()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 7.8, 14.55 };

            int result = list.CountDuplicates();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountValue_ReturnsCorrectValue()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            int result = list.CountValue(3.1);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void RemoveDuplicates_RemovesDuplicates()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            list.RemoveDuplicates();
            int result = list.Count;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CopyWithoutDuplicates_ReturnsCorrectList()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            List<double> newList = list.CopyWithoutDuplicates();
            int result = newList.Count;

            Assert.AreEqual(3, result);
            Assert.AreEqual(6, list.Count);
        }

        [TestMethod]
        public void Fill_RefillsList()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            list.Fill(10,5.5);
            int result = list.Count;

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Append_AppendsToList()
        {
            List<double> list = new List<double> { 4.2, 4.2, 3.1, 3.1, 3.1, 14.55 };

            list.Append(10, 5.5);
            //list.Append(5,'a'); // This actually works, 'a' will be cast to a double value of 97
            //list.Append(5, 'b');
            int result = list.Count;

            Assert.AreEqual(16, result);
        }
    }
}
