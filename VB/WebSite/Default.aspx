<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web" TagPrefix="dxwgv" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<dxwgv:ASPxGridView runat="server" ID="grid" EnableRowsCache="false" KeyFieldName="__Key"
			OnLoad="grid_Load"
			OnCustomUnboundColumnData="grid_CustomUnboundColumnData" >
			<Columns>
				<dxwgv:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="0" />
				<dxwgv:GridViewDataTextColumn FieldName="LastName" VisibleIndex="1" />
				<dxwgv:GridViewDataTextColumn FieldName="__Key" Visible="False" UnboundType="String" />
			</Columns>
			<SettingsDetail ShowDetailRow="True" />
			<Templates>
				<DetailRow>
					<dxwgv:ASPxGridView runat="server" ID="detail" EnableRowsCache="false"
						OnDataBinding="detail_DataBinding">
						<SettingsDetail IsDetailGrid="true" />
					</dxwgv:ASPxGridView>
				</DetailRow>
			</Templates>
		</dxwgv:ASPxGridView>
	</form>
</body>
</html>
