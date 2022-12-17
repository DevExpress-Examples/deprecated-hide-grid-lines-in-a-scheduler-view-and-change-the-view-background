Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels

    Public Class SchedulingViewModel
        Inherits ViewModelBase

        Public Sub New()
            Appointments = DataHelper.GetAppointments()
            Resources = DataHelper.GetResources()
        End Sub

        Public Property Appointments As ObservableCollection(Of AppointmentViewModel)
            Get
                Return GetValue(Of ObservableCollection(Of AppointmentViewModel))()
            End Get

            Set(ByVal value As ObservableCollection(Of AppointmentViewModel))
                SetValue(value)
            End Set
        End Property

        Public Property Resources As ObservableCollection(Of ResourceViewModel)
            Get
                Return GetValue(Of ObservableCollection(Of ResourceViewModel))()
            End Get

            Set(ByVal value As ObservableCollection(Of ResourceViewModel))
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class AppointmentViewModel
        Inherits ViewModelBase

        Public Property Id As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property StartTime As Date
            Get
                Return GetValue(Of Date)()
            End Get

            Set(ByVal value As Date)
                SetValue(value)
            End Set
        End Property

        Public Property EndTime As Date
            Get
                Return GetValue(Of Date)()
            End Get

            Set(ByVal value As Date)
                SetValue(value)
            End Set
        End Property

        Public Property Subject As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property ResourceId As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class ResourceViewModel
        Inherits ViewModelBase

        Public Property Id As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property Caption As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
