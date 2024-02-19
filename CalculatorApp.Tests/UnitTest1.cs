using CalculatorApp;
using CalculatorApp.Models;
using System.Data;
namespace CalculatorApp.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[DataTestMethod]
		[DataRow(15, OperatorEnum.Add, 5, 20)]
		[DataRow(15, OperatorEnum.Subtract, 5, 10)]
		[DataRow(15, OperatorEnum.Multiply, 5, 75)]
		[DataRow(15, OperatorEnum.Divide, 5, 3)]
		public void TestIntegerCalculation(decimal totalValue, OperatorEnum inputOperator, decimal inputValue, decimal resultValue)
		{
			// Arrange
			
			var calc = new CalculateResult();
			calc.Total = totalValue;
			calc.Operator = inputOperator;
			calc.Total = totalValue;
			// Act
			calc.Calculate();
			// Assert
			Assert.AreEqual(15, calc.Total);
		}
	}
}