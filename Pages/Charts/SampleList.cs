﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
       public List<Sample> Chart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Line Chart",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Spline Chart",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Spline",
                FileName = "Spline.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Step Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StepLine",
                FileName = "StepLine.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Inversed Spline",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/InversedSpline",
                FileName = "InversedSpline.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedLine",
                FileName = "StackedLine.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "100% Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedLine100",
                FileName = "StackedLine100.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Area",
                FileName = "Area.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/SplineArea",
                FileName = "SplineArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StepArea",
                FileName = "StepArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedArea",
                FileName = "StackedArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "100% Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedArea100",
                FileName = "StackedArea100.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Area Empty",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/AreaEmpty",
                FileName = "AreaEmpty.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Chart",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Column",
                FileName = "Column.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Rounded Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RoundedColumn",
                FileName = "RoundedColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Placement",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/ColumnPlacement",
                FileName = "ColumnPlacement.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Range Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RangeColumn",
                FileName = "RangeColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Range Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RangeBar",
                FileName = "RangeBar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bar Chart",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Bar",
                FileName = "Bar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedColumn",
                FileName = "StackedColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedColumn100",
                FileName = "StackedColumn100.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedBar",
                FileName = "StackedBar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedBar100",
                FileName = "StackedBar100.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Negative Stack",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/NegativeStack",
                FileName = "NegativeStack.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Scatter Plot",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "Charts/Scatter",
                FileName = "Scatter.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bubble",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "Charts/Bubble",
                FileName = "Bubble.razor",
                Type = SampleType.New
            },           
            new Sample
            {
                Name = "Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Waterfall",
                FileName = "Waterfall.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Box and Whisker",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/BoxandWhisker",
                FileName = "BoxandWhisker.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Error Bar",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/ErrorBar",
                FileName = "ErrorBar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "TrendLines",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/TrendLines",
                FileName = "TrendLines.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multi Series Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/MultiSeriesChart",
                FileName = "MultiSeriesChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pareto",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Pareto",
                FileName = "Pareto.razor",
                Type = SampleType.New
            },
			new Sample
            {
                Name = "Accumulation Distributions",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/ADIChart",
                FileName = "ADIChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "ATR",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/ATRChart",
                FileName = "ATRChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bollinger",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/BollingerChart",
                FileName = "BollingerChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "EMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/EmaChart",
                FileName = "EmaChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "MACD",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/MacdChart",
                FileName = "MacdChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Momentum",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/MomentumChart",
                FileName = "MomentumChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "RSI",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/RsiChart",
                FileName = "RsiChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "SMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/SmaChart",
                FileName = "SmaChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stochastic",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/StochasticChart",
                FileName = "StochasticChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "TMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/TmaChart",
                FileName = "TmaChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pie Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Pie",
                FileName = "Pie.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pie Radius",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/PieRadius",
                FileName = "PieRadius.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Donut Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Donut",
                FileName = "Donut.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pyramid",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Pyramid",
                FileName = "Pyramid.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Funnel Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Funnel",
                FileName = "Funnel.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pie With Legend",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/PieLegend",
                FileName = "PieLegend.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Semi Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/SemiPie",
                FileName = "SemiPie.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Polar Line",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarLine",
                FileName = "PolarLineChart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Polar Area",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarArea",
                FileName = "PolarArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Polar StackedArea",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarStackedArea",
                FileName = "PolarStackedArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Polar Scatter",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarScatter",
                FileName = "PolarScatter.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Radar Column",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarColumn",
                FileName = "PolarColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Wind Rose",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/Polar",
                FileName = "Polar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Radar RangeColumn",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarRangeColumn",
                FileName = "PolarRangeColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Numeric Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/NumericAxis",
                FileName = "NumericAxis.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "DateTime Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/DateTimeAxis",
                FileName = "DateTimeAxis.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "DateTime Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/DateTimeCategoryAxis",
                FileName = "DateTimeCategoryAxis.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/CategoryAxis",
                FileName = "CategoryAxis.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Indexed Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/IndexedCategoryAxis",
                FileName = "IndexedCategoryAxis.razor",
                Type = SampleType.New
            },
            //  new Sample
            //{
            //    Name = "Logarithmic Axis",
            //    Category = "Chart Axes",
            //    Directory = "Charts/Chart",
            //    Url = "Charts/LogarithmicAxis",
            //    FileName = "LogarithmicScale.razor",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Multiple Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/MultipleAxis",
                FileName = "MultipleAxis.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Inversed Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/InversedAxis",
                FileName = "InversedAxis.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Smart Axis Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/SmartAxisLabels",
                FileName = "SmartAxisLabels.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Axis Crossing",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/AxisCrossing",
                FileName = "AxisCrossing.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Range Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/RangeSelection",
                FileName = "RangeSelection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Crosshair",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Crosshair",
                FileName = "Crosshair.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Trackball",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Trackball",
                FileName = "Trackball.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Zooming and Panning",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/ZoomingandPanning",
                FileName = "ZoomingandPanning.razor",
                Type = SampleType.New
            },
        };

        public List<Sample> RangeNavigator { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Range Selector",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/RangeNavigator",
                FileName = "RangeNavigator.razor",
                Type = SampleType.New
            },
            new Sample
             {
                Name = "LightWeight",
                Category = "Range Selector",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/LightWeight",
                FileName = "LightWeight.razor",
                Type = SampleType.New
            },
            //  new Sample
            //  {
            //     Name = "DateTime Axis",
            //     Category = "Axis",
            //     Directory = "Charts/RangeNavigator",
            //     Url = "RangeSelector/DateTimeAxis",
            //     FileName = "DateTimeAxis.razor",
            //     Type = SampleType.New
            // },
            //  new Sample
            //  {
            //     Name = "Numeric Axis",
            //     Category = "Axis",
            //     Directory = "Charts/RangeNavigator",
            //     Url = "RangeSelector/NumericAxis",
            //     FileName = "NumericAxis.razor",
            //     Type = SampleType.New
            // },
              new Sample
             {
                Name = "Multilevel Labels",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/Multilevel",
                FileName = "Multilevel.razor",
                Type = SampleType.New
            }
            // new Sample
            // {
            //    Name = "Empty Points",
            //    Category = "Customization",
            //    Directory = "Charts/RangeNavigator",
            //    Url = "RangeSelector/EmptyPoint",
            //    FileName = "EmptyPoint.razor",
            //    Type = SampleType.New
            //},
            // new Sample
            // {
            //    Name = "Filter",
            //    Category = "Customization",
            //    Directory = "Charts/RangeNavigator",
            //    Url = "RangeSelector/Filter",
            //    FileName = "Filter.razor",
            //    Type = SampleType.New
            //},
            // new Sample
            // {
            //    Name = "Print and Export",
            //    Category = "Export",
            //    Directory = "Charts/RangeNavigator",
            //    Url = "RangeSelector/PrintExport",
            //    FileName = "PrintExport.razor",
            //    Type = SampleType.New
            //},
            //  new Sample
            //  {
            //     Name = "RTL",
            //     Category = "Right To Left",
            //     Directory = "Charts/RangeNavigator",
            //     Url = "RangeSelector/RTL",
            //     FileName = "RTL.razor",
            //     Type = SampleType.New
            // }
        };
		
		public List<Sample> Sparkline { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sparkline",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Series Type",
                Category = "Sparkline",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/SeriesType",
                FileName = "SeriesType.razor",
                Type = SampleType.New,
            } ,
			 new Sample
            {
                Name = "Axis Value Types",
                Category = "Sparkline",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/AxisTypes",
                FileName = "AxisTypes.razor",
                Type = SampleType.New,
            }
        };
		
		public List<Sample> SmithChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Customization",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/Customization",
                FileName = "Customization.razor",
                Type = SampleType.New
            }			
        };

        public List<Sample> StockChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "StockChart",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChart",
                FileName = "Default.razor",
                Type = SampleType.New
            },
           // new Sample
           // {
           //     Name = "Hide Selector",
           //     Category = "Stock Chart",
           //     Directory = "Charts/StockChart",
           //     Url = "StockChart/HidePeriodSelector",
           //     FileName = "Hide Selector.razor",
           //     Type = SampleType.New
           // },
            new Sample
            {
                Name = "OHLC",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/OHLC",
                FileName = "OHLC.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Candlestick and Volume",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/CandlestickandVolume",
                FileName = "Candlestick and Volume.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multiple Series",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/MultipleSeries",
                FileName = "Multiple Series.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Spline",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartSpline",
                FileName = "Spline.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartArea",
                FileName = "Area.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartSplineArea",
                FileName = "SplineArea.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Inversed Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/InversedArea",
                FileName = "Inversed Area.razor",
                Type = SampleType.New
            }
        };		
    }   

}
