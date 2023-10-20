using Avalonia.Media.Imaging;
using AvaloniaCrossApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AvaloniaCrossApplication.Models
{
	public class Food
	{
		public int Id { get; set; }

		private string _Image;
		public string Image
		{
			get { return _Image; }
			set { _Image = value; ImageFromWebsite = ImageHelper.LoadFromWeb(new Uri(_Image)); } 
		}
		public Task<Bitmap?> ImageFromWebsite { get; set; } 
		public string Item { get; set; }
		public double Price { get; set; }
		public bool Select { get; set; } = false;

		public Food(string item, double price)
		{
			Item = item;
			Price = price;
		}
	}
}
