using data__base;
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

namespace HMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelindecator2.ForeColor = System.Drawing.Color.Red;
            labelindecator1.ForeColor = System.Drawing.Color.Black;
            labelindecator3.ForeColor = System.Drawing.Color.Black;
            labelindecator4.ForeColor = System.Drawing.Color.Black;


            panel1.Visible = false;
            panel2.Visible = true;
            pnl3.Visible = false;
            panel4.Visible = false;

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelindecator1.ForeColor = System.Drawing.Color.Red;
            labelindecator2.ForeColor = System.Drawing.Color.Black;
            labelindecator3.ForeColor = System.Drawing.Color.Black;
            labelindecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            pnl3.Visible = false;
            panel4.Visible = false;


        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelindecator3.ForeColor = System.Drawing.Color.Red;
            labelindecator1.ForeColor = System.Drawing.Color.Black;
            labelindecator2.ForeColor = System.Drawing.Color.Black;
            labelindecator4.ForeColor = System.Drawing.Color.Black;


            panel1.Visible = false;
            panel2.Visible = false;
            pnl3.Visible = true;
            panel4.Visible = false;

           data__base.Data db = new data__base.Data();




        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelindecator4.ForeColor = System.Drawing.Color.Red;
            labelindecator1.ForeColor = System.Drawing.Color.Black;
            labelindecator3.ForeColor = System.Drawing.Color.Black;
            labelindecator2.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel2.Visible = false;
            pnl3.Visible = false;
            panel4.Visible = true;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            pnl3.Visible = false;
            panel4.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string name = txtName.Text;
            string address = txtAddress.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            int age = Convert.ToInt32(txtAge.Text);
            string gender = comboGender.Text;
            string blood = txtBlood.Text;
            string any = txtAny.Text;
            int pid = Convert.ToInt32(txtPid.Text);
            string sym = txtSymptoms.Text;
            string diag = txtDiagnosis.Text;
            string med = txtMedicines.Text;
            string war = comboWard.Text;
            string wartype = comboWardType.Text;

            data__base.Data db = new data__base.Data();
            db.Query("insert into AddPatient values(@_Name,@_Full_Address,@_Contact,@_Age,@_Gender,@_Blood_Group,@_Major_Disease,@_pid,@_Symptoms,@_Diagnosis,@_Medicines,@_Ward,@_Ward_type)");
            db.cmd.Parameters.AddWithValue("@_Name", name);
            db.cmd.Parameters.AddWithValue("@_Full_Address", address);
            db.cmd.Parameters.AddWithValue("@_Contact", contact);
            db.cmd.Parameters.AddWithValue("@_Age", age);
            db.cmd.Parameters.AddWithValue("@_Gender", gender);
            db.cmd.Parameters.AddWithValue("@_Blood_Group", blood);
            db.cmd.Parameters.AddWithValue("@_Major_Disease", any);
            db.cmd.Parameters.AddWithValue("@_pid", pid);
            db.cmd.Parameters.AddWithValue("@_Symptoms", sym);
            db.cmd.Parameters.AddWithValue("@_Diagnosis", diag);
            db.cmd.Parameters.AddWithValue("@_Medicines", med);
            db.cmd.Parameters.AddWithValue("@_Ward", war);
            db.cmd.Parameters.AddWithValue("@_Ward_type", wartype);
            db.Run();
            MessageBox.Show("Record inserted successfully");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtBlood.Clear();
            txtPid.Clear();
            txtAny.Clear();
            txtAge.Clear();
            comboGender.ResetText();
            txtSymptoms.Clear();
            txtDiagnosis.Clear();
            txtMedicines.Clear();
            comboWard.ResetText();
            comboWardType.ResetText();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {


            data__base.Data db = new data__base.Data();

            db.Query("update AddPatient set Symptoms ='" + textBox2.Text + "' where pid='" + textBox1.Text + "'");

            db.Run();

            db.Query("update AddPatient set Diagnosis ='" + textBox3.Text + "' where pid='" + textBox1.Text + "'");

            db.Run();

            db.Query("update AddPatient set Medicines ='" + textBox4.Text + "' where pid='" + textBox1.Text + "'");

            db.Run();

            db.Query("update AddPatient set Ward ='" + comboBox1.Text + "' where pid='" + textBox1.Text + "'");

            db.Run();

            db.Query("update AddPatient set Ward_type ='" + comboBox2.Text + "' where pid='" + textBox1.Text + "'");

            db.Run();

            MessageBox.Show("Record Updated Successfully");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();






        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            

            



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" Select *from AddPatient where pid=@pid",con);
            cmd.Parameters.AddWithValue("@pid",int.Parse(textBox5.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
            {
                textBox6.Text = da.GetValue(0).ToString();
                textBox7.Text = da.GetValue(1).ToString();
                textBox8.Text = da.GetValue(2).ToString();
                textBox9.Text = da.GetValue(3).ToString();
                textBox10.Text = da.GetValue(4).ToString();
                textBox11.Text = da.GetValue(5).ToString();
                textBox12.Text = da.GetValue(6).ToString();
                textBox13.Text = da.GetValue(7).ToString();
                textBox14.Text = da.GetValue(8).ToString();
                textBox15.Text = da.GetValue(9).ToString();
                textBox16.Text = da.GetValue(10).ToString();
                textBox17.Text = da.GetValue(11).ToString();
                textBox18.Text = da.GetValue(12).ToString();
            }
            con.Close();
            
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox19.Text);

            
            
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
                con.Open();
            
            

                SqlCommand cmd = new SqlCommand("delete AddPatient where pid=@pid", con);
            


                cmd.Parameters.AddWithValue("@pid", int.Parse(textBox19.Text));
           
           



                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
                con.Close();

            textBox19.Clear();
            
           
           
           
            
            
                           
            
        }
    }
}
