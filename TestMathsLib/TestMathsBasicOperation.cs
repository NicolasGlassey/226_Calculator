using NUnit.Framework;

namespace MathsLib
{
    public class TestMathsBasicOperation
    {
        private int _op1;
        private int _op2;
        private int _res;

        [Test]
        public void Add_NomincalCase_Success()
        {
            //given
            _op1 = 3;
            _op2 = 4;
            int expectedResult = 7;
            int actualResult;

            //when
            actualResult = MathsBasicsOperation.Add(_op1, _op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Substract_NomincalCase_Success()
        {
            //given
            _op1 = 3;
            _op2 = 4;
            int expectedResult = -1;
            int actualResult;

            //when
            actualResult = MathsBasicsOperation.Substract(_op1, _op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Multiply_NomincalCase_Success()
        {
            //given
            _op1 = 3;
            _op2 = 4;
            int expectedResult = 12;
            int actualResult;

            //when
            actualResult = MathsBasicsOperation.Multiply(_op1, _op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Divide_NomincalCase_Success()
        {
            //given
            _op1 = 8;
            _op2 = 4;
            int expectedResult = 2;
            int actualResult;

            //when
            actualResult = MathsBasicsOperation.Divide(_op1, _op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}