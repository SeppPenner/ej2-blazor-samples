﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Schedule { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Default",
                FileName = "Default.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Schedule",
                Url = "Schedule/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Schedule/Schedule",
                Url = "Schedule/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Schedule",
                Url = "Schedule/RecurrenceEvents",
                FileName = "RecurrenceEvents.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Blocking Dates and Time",
                Category = "Appointments",
                Directory = "Schedule/Schedule",
                Url = "Schedule/BlockEvents",
                FileName = "BlockEvents.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Views",
                FileName = "Views.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Timeline View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Timeline",
                FileName = "Timeline.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Agenda View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Agenda",
                FileName = "Agenda.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Month Agenda View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/MonthAgenda",
                FileName = "MonthAgenda.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "View Intervals",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ExtendedViews",
                FileName = "ExtendedViews.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Shared Events",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupEditing",
                FileName = "GroupEditing.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Different Work Days",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupCustomWorkdays",
                FileName = "GroupCustomWorkdays.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Row Auto Height",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/AdaptiveRows",
                FileName = "AdaptiveRows.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Group",
                FileName = "Group.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/TimelineResourceGroup",
                FileName = "TimelineResourceGroup.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Date-wise Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupByDate",
                FileName = "GroupByDate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hierarchical Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupByChild",
                FileName = "GroupByChild.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Header Rows",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/HeaderRows",
                FileName = "HeaderRows.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Timescale",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Timescale",
                FileName = "Timescale.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Work Days",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/WorkDays",
                FileName = "WorkDays.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hide Non-Working Days",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/HideWeekend",
                FileName = "HideWeekend.razor",
                Type = SampleType.New
            },
            new Sample
            {
               Name = "Work Hours",
               Category = "Customization",
               Directory = "Schedule/Schedule",
               Url = "Schedule/WorkHours",
               FileName = "WorkHours.razor",
               Type = SampleType.New
            },
            new Sample
            {
                Name = "Day Hour Limit",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/DayHourLimit",
                FileName = "DayHourLimit.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Cell Dimension",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/CellDimensions",
                FileName = "CellDimensions.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Read-only Events",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ReadonlyEvents",
                FileName = "ReadonlyEvents.razor",
                Type = SampleType.New
            }
        };
    }
}
