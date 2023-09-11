using GradeCalculator;

var gradeCalculatorService = new GradeCalculatorService();

Console.Write("Enter Percentage: ");

var percentage = Convert.ToInt32(Console.ReadLine());
var grade = gradeCalculatorService.GetGradeByPercentage(percentage);

Console.WriteLine($"Student Grade: {grade}");
