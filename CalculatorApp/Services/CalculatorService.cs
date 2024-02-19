using CalculatorApp.Models;

namespace CalculatorApp.Services;

public class CalculatorService(CalculateResult calculateResultInput)
{
	private readonly int digitLimit = 20;
	public CalculateResult calculateResult = calculateResultInput;

	private decimal CalculateInternal()
	{
		return calculateResult.Operator switch
		{
			OperatorEnum.Add => calculateResult.Total + calculateResult.InputValue,
			OperatorEnum.Subtract => calculateResult.Total - calculateResult.InputValue,
			OperatorEnum.Multiply => calculateResult.Total * calculateResult.InputValue,
			OperatorEnum.Divide => calculateResult.Total / calculateResult.InputValue,
			OperatorEnum.None => calculateResult.InputValue,
			_ => throw new InvalidOperationException("Invalid operator"),
		};
	}

	public decimal Calculate()
	{
		decimal result = CalculateInternal();
		return RoundResult(result);
	}

	private decimal RoundResult(decimal result)
	{
		return Math.Round(result, digitLimit);
	}

	public void InputCancel()
	{
		calculateResult.Operator = OperatorEnum.None;
		calculateResult.InputValue = 0;
	}
	public void AllCancel()
	{
		calculateResult.Total = 0;
		calculateResult.Operator = OperatorEnum.None;
		calculateResult.InputValue = 0;
	}
}
