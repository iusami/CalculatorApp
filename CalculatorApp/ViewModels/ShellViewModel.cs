using CalculatorApp.Models;
using CalculatorApp.Services;
using Caliburn.Micro;

namespace CalculatorApp.ViewModels;

public class ShellViewModel : Screen
{
	//properties
	public CalculateResult CalculateResult { get; set; }
	public CalculatorService CalculatorService { get; set; }
	private string _inputValue = "0";
	public string InputValue
	{
		get { return _inputValue; }
		set
		{
			_inputValue = value;
			CalculatorService.calculateResult.IsCalculated = false;
			NotifyOfPropertyChange(() => InputValue);
		}
	}
	private string _totalValue = "0";
	public string TotalValue
	{
		get { return _totalValue; }
		set
		{
			_totalValue = value;
			NotifyOfPropertyChange(() => TotalValue);
		}
	}
	//constructor
	public ShellViewModel()
	{
		//initialize the CalculateResult
		var CalculateResult = new CalculateResult();
		//initialize the CalculatorService
		var CalculatorService = new CalculatorService(CalculateResult);
	}

	public void PushPlusButton()
	{
		CalculateResult.Operator = OperatorEnum.Add;
		if (!CalculateResult.IsCalculated)
		{
			CalculatorService.Calculate();
			CalculateResult.IsCalculated = true;
		}
	}

	public void PushMinusButton()
	{
		CalculateResult.Operator = OperatorEnum.Subtract;
		if (!CalculateResult.IsCalculated)
		{
			CalculatorService.Calculate();
			CalculateResult.IsCalculated = true;
		}
	}

	public void PushMultiplyButton()
	{
		CalculateResult.Operator = OperatorEnum.Multiply;
		if (!CalculateResult.IsCalculated)
		{
			CalculatorService.Calculate();
			CalculateResult.IsCalculated = true;
		}
	}

	public void PushDivideButton()
	{
		CalculateResult.Operator = OperatorEnum.Divide;
		if (!CalculateResult.IsCalculated)
		{
			CalculatorService.Calculate();
			CalculateResult.IsCalculated = true;
		}
	}

	public void PushEqualButton()
	{
		CalculatorService.Calculate();
		CalculateResult.IsCalculated = true;
	}

}
