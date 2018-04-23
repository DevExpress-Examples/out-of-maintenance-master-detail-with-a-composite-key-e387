#Region "Using"

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
#End Region

Friend Class MasterItem
	Private m_firstName, m_lastName As String

	Public Sub New(ByVal first As String, ByVal last As String)
		Me.m_firstName = first
		Me.m_lastName = last
	End Sub

	Public Property FirstName() As String
		Get
			Return m_firstName
		End Get
		Set(ByVal value As String)
			m_firstName = value
		End Set
	End Property
	Public Property LastName() As String
		Get
			Return m_lastName
		End Get
		Set(ByVal value As String)
			m_lastName = value
		End Set
	End Property
End Class

Friend Class DetailItem
	Private m_firstNameKey, m_lastNameKey As String
	Private m_orderId As Integer
	Private m_customerName As String

	Public Sub New(ByVal firstNameKey As String, ByVal lastNameKey As String, ByVal orderId As Integer, ByVal customerName As String)
		Me.m_firstNameKey = firstNameKey
		Me.m_lastNameKey = lastNameKey
		Me.m_orderId = orderId
		Me.m_customerName = customerName
	End Sub

	Public Property FirstNameKey() As String
		Get
			Return m_firstNameKey
		End Get
		Set(ByVal value As String)
			m_firstNameKey = value
		End Set
	End Property
	Public Property LastNameKey() As String
		Get
			Return m_lastNameKey
		End Get
		Set(ByVal value As String)
			m_lastNameKey = value
		End Set
	End Property
	Public Property OrderId() As Integer
		Get
			Return m_orderId
		End Get
		Set(ByVal value As Integer)
			m_orderId = value
		End Set
	End Property
	Public Property CustomerName() As String
		Get
			Return m_customerName
		End Get
		Set(ByVal value As String)
			m_customerName = value
		End Set
	End Property
End Class

Public NotInheritable Class DataProvider
	Private Sub New()
	End Sub
	Public Shared Function CreateMasterData() As IEnumerable
		Dim list As List(Of MasterItem) = New List(Of MasterItem)()
		list.Add(New MasterItem("Nancy", "Davolio"))
		list.Add(New MasterItem("Andrew", "Fuller"))
		Return list
	End Function
	Public Shared Function CreateDetailData(ByVal firstName As String, ByVal lastName As String) As IEnumerable
		Dim list As List(Of DetailItem) = New List(Of DetailItem)()
		Select Case firstName & lastName
			Case "NancyDavolio"
				list.Add(New DetailItem(firstName, lastName, 10258, "Ernst Handel"))
				list.Add(New DetailItem(firstName, lastName, 10270, "Wartian Herkku"))
				list.Add(New DetailItem(firstName, lastName, 10275, "Magazzini Alimentari Riuniti"))
			Case "AndrewFuller"
				list.Add(New DetailItem(firstName, lastName, 10265, "Blondel pere et fils"))
				list.Add(New DetailItem(firstName, lastName, 10277, "Morgenstern Gesundkost"))
				list.Add(New DetailItem(firstName, lastName, 10280, "Berglunds snabbkop"))
		End Select
		Return list
	End Function
End Class