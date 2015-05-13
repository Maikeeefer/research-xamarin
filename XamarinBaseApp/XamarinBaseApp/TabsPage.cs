using System;

using Xamarin.Forms;

namespace XamarinBaseApp
{
	public class TabsPage : TabbedPage
	{
		public TabsPage ()
		{
			this.Children.Add (new RootPage () {Title = "Main"}); 
			this.Children.Add (new ListItemPage () {Title = "List"}); 
			this.Children.Add (new GridPage () {Title = "Grid"}); 
		}
	}
}


