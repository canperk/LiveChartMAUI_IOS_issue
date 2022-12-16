﻿using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace DenemeSil;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		LiveCharts.Configure(config =>
				config
					.AddSkiaSharp()
					.AddDefaultMappers()
					.AddLightTheme()
				);
	}
}
