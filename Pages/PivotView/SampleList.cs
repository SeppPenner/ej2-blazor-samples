﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Chart",
                FileName = "Chart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/GroupingBar",
                FileName = "GroupingBar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/ConditionalFormatting",
                FileName = "ConditionalFormatting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/SummaryCustomization",
                FileName = "SummaryCustomization.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Toolbar",
                FileName = "Toolbar.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/CalculatedField",
                FileName = "CalculatedField.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Aggregation",
                FileName = "Aggregation.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DefaultSorting",
                FileName = "DefaultSorting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/ValueSorting",
                FileName = "ValueSorting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/MemberFiltering",
                FileName = "MemberFiltering.razor",
                Type = SampleType.New
            }
            //new Sample
            //{
            //    Name = "Label Filtering",
            //    Category = "Filtering",
            //    Directory = "PivotView/PivotTable",
            //    Url = "PivotTable/LabelFiltering",
            //    FileName = "LabelFiltering.razor",
            //    Type = SampleType.New
            //},
            //new Sample
            //{
            //    Name = "Value Filtering",
            //    Category = "Filtering",
            //    Directory = "PivotView/PivotTable",
            //    Url = "PivotTable/ValueFiltering",
            //    FileName = "ValueFiltering.razor",
            //    Type = SampleType.New
            //},
            //new Sample
            //{
            //    Name = "Editing",
            //    Category = "Miscellaneous",
            //    Directory = "PivotView/PivotTable",
            //    Url = "PivotTable/Editing",
            //    FileName = "Editing.razor",
            //    Type = SampleType.New
            //},
            //new Sample
            //{
            //    Name = "Drill Through",
            //    Category = "Miscellaneous",
            //    Directory = "PivotView/PivotTable",
            //    Url = "PivotTable/DrillThrough",
            //    FileName = "DrillThrough.razor",
            //    Type = SampleType.New
            //},
            //new Sample
            //{
            //    Name = "Hyperlink",
            //    Category = "Miscellaneous",
            //    Directory = "PivotView/PivotTable",
            //    Url = "PivotTable/HyperLink",
            //    FileName = "HyperLink.razor",
            //    Type = SampleType.New
            //}
        };
    }
}