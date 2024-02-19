using CalculatorApp.Models;
using CalculatorApp.Services;
using System.Data;
namespace CalculatorApp.Tests
{
	[TestClass]
	public class CalculateTest
	{
		[DataTestMethod]
		[DataRow(15, OperatorEnum.Add, 5, 20)]
		[DataRow(15, OperatorEnum.Subtract, 5, 10)]
		[DataRow(15, OperatorEnum.Multiply, 5, 75)]
		[DataRow(15, OperatorEnum.Divide, 5, 3)]
		public void TestIntegerCalculation(int totalValue, OperatorEnum inputOperator, int inputValue, int resultValue)
		{
			// Arrange

			var calculateResult = new CalculateResult
			{
				Total = Convert.ToDecimal(totalValue),
				Operator = inputOperator,
				InputValue = Convert.ToDecimal(inputValue)
			};
			var calculatorService = new CalculatorService(calculateResult);
			// Act
			var currentResult = calculatorService.Calculate();
			// Assert
			Assert.AreEqual(resultValue, currentResult);
		}
	}
}