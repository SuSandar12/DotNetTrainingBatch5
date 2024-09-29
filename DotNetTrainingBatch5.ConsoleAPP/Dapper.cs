﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DotNetTrainingBatch5.ConsoleAPP.Models;

namespace DotNetTrainingBatch5.ConsoleAPP
{

    public class Dapper
    {
        private readonly string _connectionString = "Data Source=SQLEXPRESS;Initial Catalog=DotNetBatch5_DB;User ID=sa;Password=root;";
        public void Read()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "select * from Tbl_blog where DeleteFlag = 0;";
                var lst = db.Query<BlogDataModel>(query).ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.BlogId);
                    Console.WriteLine(item.BlogTitle);
                    Console.WriteLine(item.BlogAuthor);
                    Console.WriteLine(item.BlogContent);
                }

            }
        }
        public void Create(string title, string author, string content)
        {
            string query = $@"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent]
           ,[DeleteFlag])
     VALUES
           (@BlogTitle
           ,@BlogAuthor
           ,@BlogContent
           ,0)";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                int result = db.Execute(query, new BlogDataModel
                {
                    BlogTitle = title,
                    BlogAuthor = author,
                    BlogContent = content });
                Console.WriteLine(result == 1 ? "Success" : "Failed");


            }

        }

        public void Edit(int id) 
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "select * from tbl_blog where DeleteFlag = 0 and BlogId = @BlogId";
                var item =db.Query <BlogDataModel>(query, new BlogDataModel
                {
                    BlogId = id
                }).FirstOrDefault();

                if (item is  null)
                {
                    Console.WriteLine($"No data in Table id={id}");
                    return;
                }

                Console.WriteLine($"BlogId= {item.BlogId}");
                Console.WriteLine($"BlogTitle= {item.BlogTitle}");
                Console.WriteLine($"BlogAuthor= {item.BlogAuthor}");
                Console.WriteLine($"BlogContent= {item.BlogContent}");
            }        
        }

        public void Delete(string title )
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "Delete from tbl_blog where DeleteFlag = 0 and BlogTitle = @BlogTitle";
                var item = db.Query<BlogDataModel>(query, new BlogDataModel
                {
                    BlogTitle = title
                }).FirstOrDefault();

                if (item is null)
                {
                    Console.WriteLine($"No data in Table like this title='{title}'");
                    return;
                }

                Console.WriteLine($"BlogId= {item.BlogId}");
                Console.WriteLine($"BlogTitle= {item.BlogTitle}");
                Console.WriteLine($"BlogAuthor= {item.BlogAuthor}");
                Console.WriteLine($"BlogContent= {item.BlogContent}");
            }
        }

    }
}
