using System;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    class DataHelper {
        public static ObservableCollection<AppointmentViewModel> GetAppointments() {
            ObservableCollection<AppointmentViewModel> collection = new ObservableCollection<AppointmentViewModel>() {
                new AppointmentViewModel() {
                    Id = 1,
                    StartTime = DateTime.Today.AddDays(-1),
                    EndTime = DateTime.Today.AddDays(4),
                    ResourceId = 1,
                    Subject = "Task 1"
                },
                new AppointmentViewModel() {
                    Id = 2,
                    StartTime = DateTime.Today,
                    EndTime = DateTime.Today.AddDays(5),
                    ResourceId = 1,
                    Subject = "Task 2"
                },
                new AppointmentViewModel() {
                    Id = 3,
                    StartTime = DateTime.Today.AddDays(2),
                    EndTime = DateTime.Today.AddDays(7),
                    ResourceId = 2,
                    Subject = "Task 3"
                },
            };                       
            return collection;
        }

        public static ObservableCollection<ResourceViewModel> GetResources() {
            ObservableCollection<ResourceViewModel> collection = new ObservableCollection<ResourceViewModel>() {
                new ResourceViewModel() {
                    Id = 1,
                    Caption = "Work"
                },
                new ResourceViewModel() {
                    Id = 2,
                    Caption = "Personal"
                },                
            };
            return collection;
        }
    }
}