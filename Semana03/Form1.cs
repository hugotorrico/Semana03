using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace Semana03
{
    public partial class Form1 : Form
    {
        //SqlConnection connection =
        //     new SqlConnection("Server=DESKTOP-8DIVAMC; Database=TecsupDB; Integrated Security=True");
        SqlConnection connection =
             new SqlConnection("Server=DESKTOP-8DIVAMC; Database=TecsupDB; User Id=usrTecsup; Password=123456");

        BPerson bPerson = new BPerson();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         


        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {              
                connection.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception)
            {
                MessageBox.Show("Error de Conexión");

                //throw;
            }
            

            


        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {                
                connection.Close();
                MessageBox.Show("Conexion Cerrada");
            }
            catch (Exception)
            {
                MessageBox.Show("Error de  Conexión");                
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrimos la conexión
                connection.Open();

                //Creamos nuestra consulta
                SqlCommand command =
                    new SqlCommand("SELECT  * FROM PEOPLE", connection);

                //Ejecutamos consulta
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    MessageBox.Show(reader["FirstName"].ToString());
                }

                connection.Close();

                MessageBox.Show("Conexion Cerrada");

            }
            catch (Exception)
            {
                MessageBox.Show("Error de  Conexión");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Abrimos la conexión
                connection.Open();

                //Creamos nuestra consulta
                SqlCommand command =
                    new SqlCommand("SELECT  * FROM PEOPLE", connection);

                //Creamos el adaptador
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                //Instancio el dataset
                DataSet dataSet = new DataSet();

                //Adapter llena el data set
                adapter.Fill(dataSet);
                                              
                connection.Close();

                MessageBox.Show("Conexion Cerrada");

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    MessageBox.Show(
                        dataSet.Tables[0].Rows[i]["FirstName"].ToString()
                        );

                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error de  Conexión");
            }

        }

        private void btnListarGrilla_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrimos la conexión
                connection.Open();

                //Creamos nuestra consulta
                SqlCommand command =
                    new SqlCommand("USP_SelPeople", connection);
                
                command.CommandType = CommandType.StoredProcedure;


                //Creamos el adaptador
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                //Instancio el dataset
                DataTable dataTable = new DataTable();

                //Adapter llena el data set
                adapter.Fill(dataTable);

                connection.Close();

                MessageBox.Show("Conexion Cerrada");

                dataGridView1.DataSource = dataTable;

              

            }
            catch (Exception)
            {
                MessageBox.Show("Error de  Conexión");
            }
        }

        private void btnGrillaDesconectado_Click(object sender, EventArgs e)
        {

            try
            {
                //Abrimos la conexión
                connection.Open();

                //Creamos nuestra consulta
                SqlCommand command =
                    new SqlCommand("USP_SelPeople", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Ejecutamos consulta
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

                dataGridView1.DataSource = people;

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error de  Conexión");
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            dataGridView1.DataSource =
                bPerson.GetPeopleByLastName(txtLastName2.Text);
        }

        private void txtLastName2_TextChanged(object sender, EventArgs e)
        {            
            dataGridView1.DataSource =
                bPerson.GetPeopleByLastName(txtLastName2.Text);
        }
   
        private void btnSearchFilter_Click(object sender, EventArgs e)
        {                       
                dataGridView1.DataSource = 
                    bPerson.GetPeopleByLastNameFirstName(txtLastName3.Text,txtFirstName3.Text);
          
        }
    }
}
