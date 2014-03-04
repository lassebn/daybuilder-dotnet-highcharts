using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsBubbleStatesHover
	{
		/// <summary>
		/// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend..
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The width of the line connecting the data points.
		/// Default: 0
		/// </summary>
		public Number? LineWidth { get; set; }

		public PlotOptionsBubbleStatesHoverMarker Marker { get; set; }

	}

}