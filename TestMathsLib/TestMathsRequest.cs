using NUnit.Framework;

namespace MathsLib
{
    public class TestMathsRequest
    {
        private MathsRequest _mathsRequest = null;
        private int _op1;
        private int _op2;
        private char _oper;

        [SetUp]
        public void Setup()
        {
            _op1 = 3;
            _op2 = 4;
            _oper = '+';
            _mathsRequest = new MathsRequest(_op1, _oper, _op2);
        }

        [Test]
        public void Op1_NomincalCase_Success()
        {
            //given
            int expectedResult = _op1;
            int actualResult;

            //when
            actualResult = _mathsRequest.Op1;

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Op2_NomincalCase_Success()
        {
            //given
            int expectedResult = _op2;
            int actualResult;

            //when
            actualResult = _mathsRequest.Op2;

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Oper_NomincalCase_Success()
        {
            //given
            int expectedResult = _oper;
            int actualResult;

            //when
            actualResult = _mathsRequest.Oper;

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}