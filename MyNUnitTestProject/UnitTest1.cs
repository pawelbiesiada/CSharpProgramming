using BasicCSharpConsoleNET.Exercises.Workshop;

namespace MyNUnitTestProject
{
    public class Tests
    {
        //[SetUp]
        ////[OneTimeSetUp]
        //public void Setup()
        //{
        //}

        [Test]
        //[TestCase]
        public void CheckIfConstructorDoesNotThrowException()
        {
            //assign
            //act
            var primeValidator = new PrimeNumberValidator();


            //assert
            Assert.Pass();
        }

        [Test]
        public void IsPrimeNumber_7_ReturnsTrue()
        {
            //Given
            var validator = new PrimeNumberValidator();
            int number = 7;

            //When
            bool result = validator.SprawdzCzyPierwsza(number);

            //Then
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }


        public void IsPrimeNumber_5_ReturnsTrue()
        {
            //Given
            var validator = new PrimeNumberValidator();
            int number = 5;

            //When
            bool result = validator.SprawdzCzyPierwsza(number);

            //Then
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [TestCase(2, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(-12, false)]
        [TestCase(1, false)]
        public void ValidateIfGivenNumberIsPrimeNumber(int numberToValidate, bool isPrime)
        {
            //Given
            var validator = new PrimeNumberValidator();
            int number = numberToValidate;

            //When
            bool result = validator.SprawdzCzyPierwsza(number);

            //Then
            //Assert.IsTrue(result);
            Assert.That(result, isPrime ? Is.True : Is.False);
        }
    }
}
