Imports System
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels
	Friend Class DataHelper
		Public Shared Function GetAppointments() As ObservableCollection(Of AppointmentViewModel)
			Dim collection As New ObservableCollection(Of AppointmentViewModel)() From {
				New AppointmentViewModel() With {
					.Id = 1,
					.StartTime = DateTime.Today.AddDays(-1),
					.EndTime = DateTime.Today.AddDays(4),
					.ResourceId = 1,
					.Subject = "Task 1"
				},
				New AppointmentViewModel() With {
					.Id = 2,
					.StartTime = DateTime.Today,
					.EndTime = DateTime.Today.AddDays(5),
					.ResourceId = 1,
					.Subject = "Task 2"
				},
				New AppointmentViewModel() With {
					.Id = 3,
					.StartTime = DateTime.Today.AddDays(2),
					.EndTime = DateTime.Today.AddDays(7),
					.ResourceId = 2,
					.Subject = "Task 3"
				}
			}
			Return collection
		End Function

		Public Shared Function GetResources() As ObservableCollection(Of ResourceViewModel)
			Dim collection As New ObservableCollection(Of ResourceViewModel)() From {
				New ResourceViewModel() With {
					.Id = 1,
					.Caption = "Work"
				},
				New ResourceViewModel() With {
					.Id = 2,
					.Caption = "Personal"
				}
			}
			Return collection
		End Function
	End Class
End Namespace