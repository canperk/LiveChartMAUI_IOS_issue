using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;

namespace DenemeSil;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

[ObservableObject]
public partial class ChartViewModel
{
	public ISeries[] Series { get; set; } =
	{
		new LineSeries<double>
		{
			Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
			Fill = null
		}
	};

	public LabelVisual Title { get; set; } =
		new LabelVisual
		{
			Text = "My chart title",
			TextSize = 25,
			Padding = new LiveChartsCore.Drawing.Padding(15),
			Paint = new SolidColorPaint(SKColors.DarkSlateGray)
		};
}