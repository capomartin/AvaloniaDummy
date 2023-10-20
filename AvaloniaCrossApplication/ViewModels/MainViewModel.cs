using Avalonia.Collections;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaCrossApplication.Models;
using System.Net.Http;
using System;
using System.Net.Http.Json;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using AvaloniaCrossApplication.Views;
using Avalonia;
using System.Linq;
using ReactiveUI;
using Avalonia.Animation.Easings;
using AvaloniaCrossApplication.ViewModels;

namespace AvaloniaCrossApplication.ViewModels;

public class MainViewModel : ViewModelBase
{

	public ObservableCollection<Food> Food { get; }

	private Food? item;
	public Food? Item
	{
		get => item;
		set => this.RaiseAndSetIfChanged(ref item, value);
	}

	private bool selected = false;
	public bool Selected
	{
		get => selected;
		set => this.RaiseAndSetIfChanged(ref selected, value);
	}
	public MainViewModel()
	{
		using (var client = new HttpClient())
		{
			var food = client.GetFromJsonAsync<IEnumerable<Food>>("https://donpiponne.com.ar/api_food/index.php").Result;


			Food = new ObservableCollection<Food>(food);

		}

	}

	public void BackItem()
	{
		Selected = false;
	}




}

