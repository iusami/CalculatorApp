namespace CalculatorApp.Models;

public class CalculateResult
{
	public decimal Total { get; set; }
	public decimal InputValue { get; set; }
	public OperatorEnum Operator { get; set; }
	public bool IsCalculated { get; set; }
}
