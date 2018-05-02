using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//1. ADO.Net Library
using System.Data.SqlClient;//2. Add the provider
using System.Data.OleDb;
//using SerializationLibrary;


namespace MyDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //----- Connected Architecture
                //1. Make a connection
                SqlConnection con;
                //2. Fire the query
                SqlCommand cmd;
                //3. Exceute the query and store the result
                SqlDataReader dr;
                string conStr = "Data Source=dotnetmilen423.ce81h2ociexh.us-east-2.rds.amazonaws.com;Initial Catalog=Restaurants;Integrated Security=True";
                // string query = "select * from Sales.Customers";
                string query = "showRestaurants";
                //int id = 78;
                try
                {
                    using (con = new SqlConnection(conStr))   //problem here
                    {
                        //1.1 open the connection
                        con.Open();
                        cmd = new SqlCommand(query, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter parameter = new SqlParameter("@BusinessEntityID", id);
                       /* SqlParameter parameter1 = new SqlParameter("@productname", "pan");
                        cmd.Parameters.Add(parameter1);                  //problem here

                        SqlParameter parameter2 = new SqlParameter("@supplierid", 2);
                        cmd.Parameters.Add(parameter2);

                        SqlParameter parameter3 = new SqlParameter("@categoryid", 3);
                        cmd.Parameters.Add(parameter3);

                        SqlParameter parameter4 = new SqlParameter("@unitprice", 8.00);
                        cmd.Parameters.Add(parameter4);

                        SqlParameter parameter5 = new SqlParameter("@discontinued", 0);
                        cmd.Parameters.Add(parameter5);*/

                        dr = cmd.ExecuteReader();
                        //Console.WriteLine("Output of Sales.Customers");
                        //
                        Console.WriteLine("Output of ShowRestaurants");
                        while (dr.Read())
                        {
                        //Console.WriteLine(dr["BusinessEntityID"]+" "+dr["firstName"] +" "+dr["lastName"]);
                        //Console.WriteLine(dr[0]+" ||"+dr[1]+"  || "+dr[2]+"|| "+dr["city"]+" || "+dr["country"]+ " || "+dr["name"]);
                        //Console.WriteLine(dr["ProductName"] + " " + dr["supplierID"] + " " + dr["categoryID"] + " " + dr["unitPrice"] + " " + dr["discontinued"]);
                        //Console.WriteLine(dr[0] + " ||" + dr[1] + "  || " + dr[2] + "|| " + dr[3] + " || " + dr[4]);
                        Console.WriteLine("I'm reading the restaurants...");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            /*Class1.Serialize();
            Console.WriteLine("I'm up and going. ");*/
        }
        }
    }

