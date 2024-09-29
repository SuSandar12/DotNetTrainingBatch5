using DotNetTrainingBatch5.ConsoleAPP;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Welcome from HSS World!");
string connectionString = "Data Source=Data Source=SQLEXPRESS;Initial Catalog=DotNetBatch5_DB;User ID=sa;Password=root;";
Console.WriteLine("Connection string: " + connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection is opening...");
connection.Open();
Console.WriteLine("Connection was opened.");

//string query = @"SELECT [BlogId]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//      ,[DeleteFlag]
//  FROM [dbo].[Tbl_Blog] where DeleteFlag = 0";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);
//SqlDataReader reader = cmd.ExecuteReader();
//while (reader.Read())
//{
//    Console.WriteLine($"BlogId: {reader["BlogId"]}");
//    Console.WriteLine($"BlogTitle: {reader["BlogTitle"]}");
//    Console.WriteLine($"BlogAuthor: {reader["BlogAuthor"]}");
//    Console.WriteLine($"BlogContent: {reader["BlogContent"]}");
//    Console.WriteLine($"DeleteFlag: {reader["DeleteFlag"]}");
    //Console.WriteLine(dr["DeleteFlag"]);
//}

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    //Console.WriteLine(dr["DeleteFlag"]);
//}

Console.WriteLine("Connection is closing...");
connection.Close();
Console.WriteLine("Connection was closed.");

// DataSet
// DataTable
// DataRow
// DataColumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    //Console.WriteLine(dr["DeleteFlag"]);
//}

//AdoDotNet CRUD Example
//AdoDotNet adoDotNetObj = new AdoDotNet();
//adoDotNetObj.Read();
//adoDotNetObj.Create();
//adoDotNetObj.Edit();
//adoDotNetObj.Update();
//adoDotNetObj.Delete();

//Dapper CRUD Example
//DotNetTrainingBatch5.ConsoleAPP.Dapper dapperObj = new DotNetTrainingBatch5.ConsoleAPP.Dapper();
//dapperObj.Read();
//dapperObj.Edit(1);


//EFCore CURD Example
EFCore efCoreObj = new EFCore();
efCoreObj.Read();
//edCoreExample.delete(1);
//edCoreExample.update();
//edCoreExample.Edit();


Console.ReadKey();