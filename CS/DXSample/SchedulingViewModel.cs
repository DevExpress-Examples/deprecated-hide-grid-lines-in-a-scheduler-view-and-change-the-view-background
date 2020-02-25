using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class SchedulingViewModel : ViewModelBase {
        public SchedulingViewModel() {
            Appointments = DataHelper.GetAppointments();
            Resources = DataHelper.GetResources();
        }
        public ObservableCollection<AppointmentViewModel> Appointments {
            get { return GetValue<ObservableCollection<AppointmentViewModel>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<ResourceViewModel> Resources {
            get { return GetValue<ObservableCollection<ResourceViewModel>>(); }
            set { SetValue(value); }
        }
    }
    public class AppointmentViewModel : ViewModelBase {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public DateTime StartTime {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public DateTime EndTime {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public string Subject {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public int ResourceId {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
    }
    public class ResourceViewModel : ViewModelBase {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }        
        public string Caption {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}