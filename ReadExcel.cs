using OpenQA.Selenium.DevTools.V112.Page;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBot
{
    class ReadExcel
    {

        public DataTable getDTFromExcel(string str_file)
        {

            OleDbConnection connection = null;
			OleDbCommand cmd = null;
			OleDbDataAdapter adapter = null;
            DataTable dt_result = null;
            DataSet dataSet = null;

            try
            {
                Console.WriteLine($"[DEBUG] Lendo Arquivo: {str_file}");

				connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source='" + str_file + "';Extended Properties='Excel 12.0 Xml;HDR=NO'");

                cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from [Sheet1$]";

                adapter = new OleDbDataAdapter(cmd);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                
                dt_result = new DataTable();
                dt_result = dataSet.Tables[0];

                //Delete empty lines
                dt_result = dt_result.Rows.Cast<DataRow>()
            .Where(row => !row.ItemArray.All(item => item is DBNull || string.IsNullOrWhiteSpace(item.ToString())))
            .CopyToDataTable();


            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
            }
            finally
            {
                if(connection != null)
                {
                    connection.Dispose();
                }
            }

			return dt_result;
        }

    }
}
