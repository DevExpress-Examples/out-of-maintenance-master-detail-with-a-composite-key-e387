#region Using
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
#endregion

public partial class _Default : System.Web.UI.Page {
	protected void grid_Load(object sender, EventArgs e) {
		ASPxGridView grid = (ASPxGridView)sender;
		grid.DataSource = DataProvider.CreateMasterData();
		grid.DataBind();
	}
	protected void grid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
		if(e.Column.FieldName == "__Key")
			e.Value = e.GetListSourceFieldValue("FirstName").ToString() + e.GetListSourceFieldValue("LastName").ToString();
	}
	protected void detail_DataBinding(object sender, EventArgs e) {
		ASPxGridView grid = (ASPxGridView)sender;		

		// Determine components of a composite key
		string firstNameKey = grid.GetMasterRowFieldValues("FirstName").ToString();
		string lastNameKey = grid.GetMasterRowFieldValues("LastName").ToString();
		
		grid.DataSource = DataProvider.CreateDetailData(firstNameKey, lastNameKey);		
	}
}
