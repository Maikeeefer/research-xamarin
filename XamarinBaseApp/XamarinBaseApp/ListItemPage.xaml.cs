using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinBaseApp
{
	public partial class ListItemPage : ContentPage
	{
		public static ListItem[] List { get; set;}

		public ListItemPage ()
		{
			InitializeComponent ();

			 var listView = new ListView {
				RowHeight = 40
			}; 


			/* List = new ListItem [] 
			{
				new ListItem {Name = "Buy something", Done=true},  
				new ListItem {Name = "Do something", FavoriteName = "do something"}, 
				new ListItem {Name = "Like something"}, 
				new ListItem {Name = "Blue shirt"}
			}; */ 

			listView.ItemsSource = new ListItem [] {
				new ListItem {Name = "Buy something", Done=true},  
				new ListItem {Name = "Do something", FavoriteName = "fav do something"}, 
				new ListItem {Name = "Like something"}, 
				new ListItem {Name = "Blue shirt"}
			}; 

			Content = new StackLayout 
			{
				VerticalOptions = LayoutOptions.FillAndExpand, 
				Children = { listView }
			}; 

			listView.ItemTemplate = new DataTemplate(typeof(TextCell));
			listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");  

			/* listView.ItemSelected += async (sender, e) => {
				await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK");
			}; */

			listView.ItemSelected += async (sender, e) => {
				if (e.SelectedItem == null)
					return; 
				await DisplayAlert ("Tapped!", e.SelectedItem + " was tapped.", "OK"); 
				((ListView)sender).SelectedItem = null; 
			}; 
		}

		void ItemListOnItemSelected(Object o, EventArgs e) {
		}
	}
}

