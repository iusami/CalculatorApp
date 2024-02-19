using CalculatorApp.Models;
using CalculatorApp.Services;

namespace CalculatorApp.Tests;

[TestClass]
public class ButtonTest
{
	[TestMethod]
	public void TestInputCancelButton()
	{
		// Arrange
		var calculateResult = new CalculateResult
		{
			Total = 15,
			Operator = OperatorEnum.Add,
			InputValue = 5
		};
		var calculatorService = new CalculatorService(calculateResult);
		// Act
		calculatorService.InputCancel();
		// Assert
		Assert.AreEqual(15, calculateResult.Total);
		Assert.AreEqual(OperatorEnum.None, calculateResult.Operator);
		Assert.AreEqual(0, calculateResult.InputValue);
	}

	[TestMethod]
	public void TestAllCancelButton()
	{
		// Arrange
		var calculateResult = new CalculateResult
		{
			Total = 15,
			Operator = OperatorEnum.Add,
			InputValue = 5
		};
		var calculatorService = new CalculatorService(calculateResult);
		// Act
		calculatorService.AllCancel();
		// Assert
		Assert.AreEqual(0, calculateResult.Total);
		Assert.AreEqual(OperatorEnum.None, calculateResult.Operator);
		Assert.AreEqual(0, calculateResult.InputValue);
	}

}
