using System.Data.SqlClient;

namespace Form_With_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAB-7-186;Initial Catalog=DataForForm;Persist Security Info=True;User ID=sa;Password=aptech;Pooling=False");
            sqlConnection.Open();
            SqlCommand commandForSql = new SqlCommand();
            commandForSql.Connection = sqlConnection;
            commandForSql.CommandText = "Insert into myData values ( '"+txtname.Text+ "' , '"+txtclass.Text+"' , '" + txtfather.Text + "' , '" + txtage.Text + "' )";
            commandForSql.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            sqlConnection.Close();
        }
    }
}