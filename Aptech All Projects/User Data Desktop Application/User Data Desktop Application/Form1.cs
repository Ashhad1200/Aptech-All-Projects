namespace User_Data_Desktop_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = name.Text;
            string lname = lastName.Text;
            int uAge = Convert.ToInt32(age.Text);
            string userCity = city.Text;
            string un = userName.Text;
            int userSalary = Convert.ToInt32(salary.Text);
            long userMobile = Convert.ToInt64(mobileNumber.Text);

            dn.Text = fname;
            dln.Text = lname;
            da.Text = uAge.ToString();
            dc.Text= userCity;
            dun.Text= un;
            ds.Text = userSalary.ToString();
            dmn.Text = userSalary.ToString();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}