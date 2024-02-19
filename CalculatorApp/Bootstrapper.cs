using Caliburn.Micro;
using System.Windows;
using CalculatorApp.ViewModels;

namespace CalculatorApp;

public class Bootstrapper: BootstrapperBase
{
	protected override void OnStartup(object sender, StartupEventArgs e) => _ = DisplayRootViewForAsync<ShellViewModel>();


}
