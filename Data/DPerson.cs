using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
  public  class DPerson
    {
        SqlConnection connection =
             new SqlConnection("Server=DESKTOP-8DIVAMC; Database=TecsupDB; User Id=usrTecsup; Password=123456");
        public List<Person> GetPeople(string LastName, string FirstName)
        {

            connection.Open();

            //Creamos nuestra consulta
            SqlCommand command =
                new SqlCommand("USP_PeopleFilter", connection);
            command.CommandType = CommandType.StoredProcedure;

            //Creamos nuestros parámetros
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@LastName";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Value = LastName;

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@FirstName";
            parameter2.SqlDbType = SqlDbType.VarChar;
            parameter2.Value = FirstName;


            //Asignamos parametros a nuestro comando
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);

            //Trabjamos con el data reader
            SqlDataReader reader = command.ExecuteReader();

            List<Person> people = new List<Person>();
            while (reader.Read())
            {
                people.Add(
                new Person
                {
                    PersonID = (int)reader["PeopleID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString()
                });
            }
            connection.Close();
            return people;
         }

    }
}
