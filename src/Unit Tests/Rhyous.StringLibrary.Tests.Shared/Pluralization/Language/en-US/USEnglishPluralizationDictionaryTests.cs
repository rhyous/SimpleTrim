﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhyous.StringLibrary.Pluralization;

namespace Rhyous.StringLibrary.Tests.Pluralization
{
    [TestClass]
    public class USEnglishPluralizationDictionaryTests
    {
        [TestMethod]
        public void USEnglishPluralizationDictionary_Constructor_Tests()
        {
            // Arrange
            // Act
            var dictionary = new USEnglishPluralizationDictionary();
            // Assert
            Assert.IsTrue(dictionary.Count > 0);
        }
    }
}
