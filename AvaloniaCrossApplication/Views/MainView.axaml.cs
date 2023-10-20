using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaCrossApplication.Models;
using AvaloniaCrossApplication.ViewModels;

namespace AvaloniaCrossApplication.Views;

public partial class MainView : UserControl
{
	public MainView()
	{

		InitializeComponent();

	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		var dataContext = (Food)((Button)sender).DataContext;

		var vm = (MainViewModel)this.DataContext;
		vm.Item = dataContext;
		vm.Selected = true;
	}
}


