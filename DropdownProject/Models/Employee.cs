using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DropdownProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public SqlConnection connection()
        {
            //add connectionstring in web.config file
            /*  </appSettings>
	                <ConnectionStrings>
		                <add name="ConStringName" ConnectionString="data source=LAPTOP-HAIAHBJF\SQLEXPRESS;database=Student;Integrated Security=True" providerName="System.Data.SqlClient"/>
	                </ConnectionStrings>
                <system.web> 
             */
            string _connectionString =ConfigurationManager.ConnectionStrings["ConStringName"].ConnectionString;
            SqlConnection con=new SqlConnection(_connectionString);
            return con;
        }
        //Add Student data
        public void AddStudent(Student stu)
        {
            //create connection
            var con = connection();
            //open the connection
            con.Open();
            //pass the query
            string query = "insert into studentDetails values('" + stu.Id + "','" + stu.Name + "','" + stu.City + "','" + stu.Gender + "','" + stu.Country + "')";
            SqlCommand cmd= new SqlCommand(query,con);
            //execute the query
            cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
        }
    }
}