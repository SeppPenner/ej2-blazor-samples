﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_treedata
{
    public class TreeData
    {
        public class BusinessObject
        {
            public int TaskId
            {
                get;
                set;
            }

            public string TaskName
            {
                get;
                set;
            }

            public DateTime StartDate
            {
                get;
                set;
            }

            public DateTime EndDate
            {
                get;
                set;
            }

            public int Duration
            {
                get;
                set;
            }

            public int Progress
            {
                get;
                set;
            }
            public string Priority
            {
                get;
                set;
            }
            public bool Approved
            {
                get;
                set;
            }

            public DateTime FilterStartDate
            {
                get;
                set;
            }
            public DateTime FilterEndDate
            {
                get;
                set;
            }

            public List<BusinessObject> Children
            {
                get;
                set;
            }

            public int? ParentId
            {
                get;
                set;
            }
        }

        public static List<BusinessObject> GetDefaultData()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();

            BusinessObject Record1 = null;

            Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 5,
                Progress = 100,
                Approved = true,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 5,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = false
            };

            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = new DateTime(2017, 07, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 1,
                Progress = 1,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 07),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = true
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);

            BusinessObject Record2 = new BusinessObject()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 14),
                Progress = 86,
                Duration = 3,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = false,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child5 = new BusinessObject()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 12),
                Duration = 3,
                Progress = 60,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            BusinessObject Child6 = new BusinessObject()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 12),
                Duration = 3,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            BusinessObject Child7 = new BusinessObject()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2017, 02, 13),
                EndDate = new DateTime(2017, 02, 14),
                Duration = 2,
                Progress = 100,
                Priority = "Low",
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 13),
                FilterEndDate = new DateTime(2017, 02, 14),
            };

            BusinessObject Child8 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Design complete",
                StartDate = new DateTime(2017, 02, 14),
                EndDate = new DateTime(2017, 02, 14),
                Duration = 1,
                Progress = 1,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 14),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = true
            };

            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            Record2.Children.Add(Child8);
            BusinessObject Record3 = new BusinessObject()
            {
                TaskId = 12,
                TaskName = "Implementation Phase",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 17),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Progress = 66,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 17),
                Children = new List<BusinessObject>(),
            };

            BusinessObject Record4 = new BusinessObject()
            {
                TaskId = 13,
                TaskName = "Phase 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = 50,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record7 = new BusinessObject()
            {
                TaskId = 14,
                TaskName = "Implementation Module 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Duration = 11,
                Progress = 10,
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child9 = new BusinessObject()
            {
                TaskId = 15,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = false
            };
            BusinessObject Child10 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = true
            };
            BusinessObject Child11 = new BusinessObject()
            {
                TaskId = 17,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 1,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true
            };
            BusinessObject Child12 = new BusinessObject()
            {
                TaskId = 18,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
                Approved = false
            };
            BusinessObject Child13 = new BusinessObject()
            {
                TaskId = 19,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false
            };
            BusinessObject Child14 = new BusinessObject()
            {
                TaskId = 20,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 50,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true
            };
            Record7.Children.Add(Child9);
            Record7.Children.Add(Child10);
            Record7.Children.Add(Child11);
            Record7.Children.Add(Child12);
            Record7.Children.Add(Child13);
            Record7.Children.Add(Child14);
            Record4.Children.Add(Record7);
            Record3.Children.Add(Record4);
            BusinessObject Record5 = new BusinessObject()
            {
                TaskId = 21,
                TaskName = "Phase 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Children = new List<BusinessObject>(),
                Priority = "High",
                Approved = false,
                Progress = 60,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
            };
            BusinessObject Record8 = new BusinessObject()
            {
                TaskId = 22,
                TaskName = "Implementation Module 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Priority = "Critical",
                Approved = false,
                Progress = 90,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child15 = new BusinessObject()
            {
                TaskId = 23,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            BusinessObject Child16 = new BusinessObject()
            {
                TaskId = 24,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            BusinessObject Child17 = new BusinessObject()
            {
                TaskId = 25,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 21),
                EndDate = new DateTime(2017, 02, 24),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 21),
                FilterEndDate = new DateTime(2017, 02, 24),
                Approved = false,
            };
            BusinessObject Child18 = new BusinessObject()
            {
                TaskId = 26,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 25),
                EndDate = new DateTime(2017, 02, 26),
                Duration = 2,
                Progress = 1,
                Priority = "Low",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 25),
                FilterEndDate = new DateTime(2017, 02, 26),
            };
            BusinessObject Child19 = new BusinessObject()
            {
                TaskId = 27,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = true,
            };
            BusinessObject Child20 = new BusinessObject()
            {
                TaskId = 28,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2017, 02, 28),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Priority = "Normal",
                Progress = 50,
                FilterStartDate = new DateTime(2017, 02, 28),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = false,
            };
            Record8.Children.Add(Child15);
            Record8.Children.Add(Child16);
            Record8.Children.Add(Child17);
            Record8.Children.Add(Child18);
            Record8.Children.Add(Child19);
            Record8.Children.Add(Child20);
            Record5.Children.Add(Record8);
            Record3.Children.Add(Record5);
            BusinessObject Record6 = new BusinessObject()
            {
                TaskId = 29,
                TaskName = "Phase 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Duration = 11,
                Progress = 30,
                Children = new List<BusinessObject>(),
            };
            BusinessObject Record9 = new BusinessObject()
            {
                TaskId = 22,
                TaskName = "Implementation Module 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = 60,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<BusinessObject>(),
            };
            BusinessObject Child21 = new BusinessObject()
            {
                TaskId = 31,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            BusinessObject Child22 = new BusinessObject()
            {
                TaskId = 32,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            BusinessObject Child23 = new BusinessObject()
            {
                TaskId = 33,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true,

            };
            BusinessObject Child24 = new BusinessObject()
            {
                TaskId = 34,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
            };
            BusinessObject Child25 = new BusinessObject()
            {
                TaskId = 35,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 1,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true,
            };
            BusinessObject Child26 = new BusinessObject()
            {
                TaskId = 36,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Priority = "Critical",
                Progress = 50,
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false,
            };
            Record9.Children.Add(Child21);
            Record9.Children.Add(Child22);
            Record9.Children.Add(Child23);
            Record9.Children.Add(Child24);
            Record9.Children.Add(Child25);
            Record9.Children.Add(Child26);
            Record6.Children.Add(Record9);
            Record3.Children.Add(Record6);
            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);
            BusinessObjectCollection.Add(Record3);

            return BusinessObjectCollection;
        }
    }     
}
