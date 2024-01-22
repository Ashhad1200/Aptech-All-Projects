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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(local); Initial Catalog= product; User ID = sa; Password= aptech");
        int id = 0;
        private void label2_Click(object sender, EventArgs e)
        {
           // SqlCommand cmd = new SqlCommand("insert into emp(e_name,e_phone,e_city,e_age)values(@en,@ep,@ec,@ea)", conn);
           // string en = EmpName.Text;
           // conn.Open();
           //cmd.Parameters.AddWithValue("@en", EmpName.Text);
           //cmd.Parameters.AddWithValue("@ep", Emp_Phone.Text);
           // cmd.Parameters.AddWithValue("@ec", EmpCity.Text);
           // cmd.Parameters.AddWithValue("@ea",Convert.ToInt32( EmpAge.Text));//21
           // cmd.ExecuteNonQuery();
           // conn.Close();
           // MessageBox.Show($"{en} Added Successfully");
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into empl(emp_name,emp_contact,emp_city,emp_age,dept_id)values(@en,@ep,@ec,@ea,@di)", conn);
            string en = EmpName.Text;
            conn.Open();
            cmd.Parameters.AddWithValue("@en", EmpName.Text);
            cmd.Parameters.AddWithValue("@ep", Emp_Phone.Text);
            cmd.Parameters.AddWithValue("@ec", EmpCity.Text);
            cmd.Parameters.AddWithValue("@ea", Convert.ToInt32(EmpAge.Text));//21
            cmd.Parameters.AddWithValue("@di", Convert.ToInt32(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"{en} Added Successfully");
            data( );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            data( );
        }
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from empl", conn);
            sda .Fill(dt); 
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        private void data( )
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select emp_name,emp_contact,emp_city,emp_age,dept_name from empl,depart where empl.dept_id = depart.dept_id", conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            data();
            combo();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(EmpName.Text != "" && Emp_Phone.Text != "" && EmpAge.Text != "" && EmpCity.Text != "")
            {
                SqlCommand cmd = new SqlCommand(" update empl set emp_name = @en,emp_contact= @ep,emp_city = @ec,emp_age =@ea where emp_id = @id",conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@en", EmpName.Text);
                cmd.Parameters.AddWithValue("@ep", Emp_Phone.Text);
                cmd.Parameters.AddWithValue("@ec", EmpCity.Text);
                cmd.Parameters.AddWithValue("@ea", Convert.ToInt32(EmpAge.Text));//21
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" Updated Successfully");
                data();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            EmpName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Emp_Phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmpCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmpAge.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void clear()
        {
            EmpName.Text = "";
            Emp_Phone.Text = "";
            EmpAge.Text = "";
            EmpCity.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)   
        {
            if (id != 0)
            {
                SqlCommand cmd = new SqlCommand("delete from empl where emp_id = @id" ,conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id",id);   
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Successfully");
                data();
                clear() ;
            }
            else
            {
                MessageBox.Show("select any data to delete");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String search = textBox1.Text;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter( $"select  *  from empl where emp_name like '%{search}%' ", conn);
            a.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
         
        Dictionary<string,int> empDic = new Dictionary<string,int>();
        private void combo()
        {
            //comboBox1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select emp_id,emp_name from empl",conn);//
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int emp_id = Convert.ToInt32(reader["emp_id"]);
                string emp_name = reader["emp_name"].ToString( );//
                empDic.Add(emp_name, emp_id);
                comboBox1.Items.Add(emp_name);//
            }
            reader.Close();
            conn.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;//
            MessageBox.Show($"{name} selected");
        }

        private void selectedEmp(int emp_id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from empl where emp_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", emp_id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName=comboBox1.SelectedItem.ToString();//
            if (empDic.TryGetValue(selectedName,out int emp_id)){
                selectedEmp(emp_id);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
