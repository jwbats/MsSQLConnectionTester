using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsSQLConnectionTester
{
	public partial class Form1 : Form
	{

		#region ================================================== Private Members ==================================================

		private string Connection
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
			}
		}

		#endregion ================================================== Private Members ==================================================




		#region ================================================== Constructor ==================================================

		public Form1()
		{
			InitializeComponent();
		}



		#endregion ================================================== Constructor ==================================================




		#region ================================================== Private Methods ==================================================

		private void tbSelectAllOnEnter(Object sender, EventArgs e)
		{
			(sender as TextBox).SelectAll();
		}

		#endregion ================================================== Private Methods ==================================================




		#region ================================================== Public Methods ==================================================

		private void _IsConnectionValid(string host, string database, string user, string password)
		{
			string connection = String.Format(Connection, host, database, user, password);

			using (SqlConnection sqlConnection = new SqlConnection(connection))
			{
				sqlConnection.Open();
			}			
		}


	
		
		private string IsConnectionValid(string dataSource, string database, string userId, string password)
		{
			try
			{
				_IsConnectionValid(dataSource, database, userId, password);
				return "Connection is valid.";
			}
			catch (Exception exception)
			{
				return exception.ToString();
			}
		}


	
		
		private void btnTestConnection_Click(object sender, EventArgs e)
		{
			string dataSource = tbDataSource.Text;
			string database   = tbInitialCatalog.Text;
			string userId     = tbUserId.Text;
			string password   = tbPassword.Text;

			tbOutput.Text = IsConnectionValid(dataSource, database, userId, password);
		}

		#endregion ================================================== Public Methods ==================================================

	}
}
