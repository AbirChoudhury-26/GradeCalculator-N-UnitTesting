namespace GradeCalculator.nUnitTest
{
    public class Tests
    {
        private GradeCalculatorService _gradeCalculator { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator= new GradeCalculatorService();
        }

        // For performing  multiple test cases
        [TestCase(92)]
        [TestCase(88)]
        [TestCase(100)]

        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            // ASSIGN

            //    var perecentage = 99;
            //ACT
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //ASSERT
            //  It can uesd to pass multiple type of test cases

            // In this we want to check which are equal in grades,i.e we used AreEqual
            //Assert.AreEqual("A", grade);
            

            // We can also use NoteEqual as AreNotEqual

            Assert.AreNotEqual("A", grade);
        }
    }
}