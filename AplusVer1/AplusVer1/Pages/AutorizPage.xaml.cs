﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusVer1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AutorizPage : ContentPage
	{
		public AutorizPage()
		{
			InitializeComponent();
		}

		private async void btn_Registr_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Pages.RegistPage());
		}
		private async void btn_Entery_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Pages.ProjectsPage());
		}
	}
}