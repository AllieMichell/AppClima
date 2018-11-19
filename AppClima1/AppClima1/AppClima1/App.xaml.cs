﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppClima1.Paginas;
using Xamarin.Forms;

namespace AppClima1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new PaginaClima(); 
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
