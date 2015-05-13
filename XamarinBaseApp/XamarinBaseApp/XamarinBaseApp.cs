using System;

using Xamarin.Forms;

namespace XamarinBaseApp
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new TabsPage(); 
		 
				/* new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}, 
						new Label {
							XAlign = TextAlignment.Center, 
							Text = "Hi App"
						}, 
						new Entry {
							
						}
					}
				}
			}; */
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

