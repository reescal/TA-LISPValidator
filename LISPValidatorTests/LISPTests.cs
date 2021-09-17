using Microsoft.VisualStudio.TestTools.UnitTesting;
using LISPValidator;

namespace LISPValidatorTests
{
    [TestClass]
    public class LISPTests
    {
        [TestMethod]
        public void String_With_No_Parentheses()
        {
            //arrange
            string noParentheses = "a";
            //act
            bool validationResult = Validator.ValidateLISP(noParentheses);
            //assert
            Assert.IsFalse(validationResult);
        }

        [TestMethod]
        public void Unequal_Number_Of_Parentheses()
        {
            //arrange
            string oddParentheses = "()(";
            //act
            bool validationResult = Validator.ValidateLISP(oddParentheses);
            //assert
            Assert.IsFalse(validationResult);
        }

        [TestMethod]
        public void Unmatched_Parentheses_1()
        {
            //arrange
            string unmatchedParentheses = ")()(";
            //act
            bool validationResult = Validator.ValidateLISP(unmatchedParentheses);
            //assert
            Assert.IsFalse(validationResult);
        }

        [TestMethod]
        public void Unmatched_Parentheses_2()
        {
            //arrange
            string unmatchedParentheses = "()((";
            //act
            bool validationResult = Validator.ValidateLISP(unmatchedParentheses);
            //assert
            Assert.IsFalse(validationResult);
        }

        [TestMethod]
        public void Unmatched_Parentheses_3()
        {
            //arrange
            string unmatchedParentheses = "())(()";
            //act
            bool validationResult = Validator.ValidateLISP(unmatchedParentheses);
            //assert
            Assert.IsFalse(validationResult);
        }

        [TestMethod]
        public void Matched_Parentheses_1()
        {
            //arrange
            string matchedParentheses = "()()";
            //act
            bool validationResult = Validator.ValidateLISP(matchedParentheses);
            //assert
            Assert.IsTrue(validationResult);
        }

        [TestMethod]
        public void Nested_Parentheses()
        {
            //arrange
            string nestedParentheses = "(()())";
            //act
            bool validationResult = Validator.ValidateLISP(nestedParentheses);
            //assert
            Assert.IsTrue(validationResult);
        }
    }
}
