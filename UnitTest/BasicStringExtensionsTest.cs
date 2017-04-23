using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Console;

namespace UnitTest
{
    [TestClass]
    public class BasicStringExtensionsTest
    {
        [TestMethod]
        public void ToPascal_LineIsEmpty_EmptyResult()
        {
            string text = string.Empty;
            text = text.ToPascal();
            Assert.AreEqual(string.Empty, text);
        }

        [TestMethod]
        public void ToPascal_LineWithBlankSpaces_ReturnedValueIsWhatSent()
        {
            string text = "  ";
            string originalValue = text;
            text = text.ToPascal();
            Assert.AreEqual(originalValue, text);
        }

        [TestMethod]
        public void ToPascal_OneCharSent_CharConvertedToPascal()
        {
            string text = "h";
            text = text.ToPascal();
            Assert.AreEqual("H", text);
        }

        [TestMethod]
        public void ToPascal_OneWordSent_WordConvertedToPascal()
        {
            string text = "hello";
            text = text.ToPascal();
            Assert.AreEqual("Hello", text);
        }

        [TestMethod]
        public void ToPascal_StringStartsWithBlankSpaces_StringConvertedToPascal()
        {
            string text = "   hello";
            text = text.ToPascal();
            Assert.AreEqual("   Hello", text);
        }

        [TestMethod]
        public void ToPascal_StringStartsWithBlankSpacesInMiddle_StringConvertedToPascal()
        {
            string text = "hello world";
            text = text.ToPascal();
            Assert.AreEqual("Hello world", text);
        }

    }
}
