#Region "Using"

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
#End Region

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub grid_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = CType(sender, ASPxGridView)
		grid.DataSource = DataProvider.CreateMasterData()
		grid.DataBind()
	End Sub
	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "__Key" Then
			e.Value = e.GetListSourceFieldValue("FirstName").ToString() & e.GetListSourceFieldValue("LastName").ToString()
		End If
	End Sub
	Protected Sub detail_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = CType(sender, ASPxGridView)

		' Determine components of a composite key
		Dim firstNameKey As String = grid.GetMasterRowFieldValues("FirstName").ToString()
		Dim lastNameKey As String = grid.GetMasterRowFieldValues("LastName").ToString()

		grid.DataSource = DataProvider.CreateDetailData(firstNameKey, lastNameKey)
	End Sub
End Class
