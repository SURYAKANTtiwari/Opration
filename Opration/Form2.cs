using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Opration
{
    public partial class Form2 : Form
    {
        String connectionst = @"Data Source=DESKTOP-50MR975\nitin;Initial Catalog=ITSolutionTest;Integrated Security=True";
        int iidd, en, cont; String fn, ln, cn, an;

        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
           iidd=Convert.ToInt32(StudentID.Text);
           en =Convert.ToInt32(Enrollmantnumber.Text);
           cont =Convert.ToInt32(ContactNumber.Text);
           fn = FirstName.Text;
           ln = LastName.Text;
           cn = ClassName.Text;
           an = Address.Text;
            SqlConnection con = new SqlConnection(connectionst);
            con.Open();
            try
            {
                String Query = "update StudentTB set Enrollmantnumber=@enrolln,FirstName = @fname,LastName=@lname,ClassName=@class,ContactNumber=@contn,Address=@ad where StudentID=@stuid";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@stuid", iidd);
                cmd.Parameters.AddWithValue("@enrolln", en);
                cmd.Parameters.AddWithValue("@fname", fn);
                cmd.Parameters.AddWithValue("@lname", ln);
                cmd.Parameters.AddWithValue("@class", cn);
                cmd.Parameters.AddWithValue("@contn", cont);
                cmd.Parameters.AddWithValue("@ad", an);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public Form2(int id,int enroll, int contact,String firstn,String lastn,String classn,String addn )
        {
            InitializeComponent();
            iidd = id;
            en = enroll;
            cont = contact;
            fn = firstn;
            ln = lastn;
            cn = classn;
            an = addn;
        }

        private void Enrollmantnum_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StudentID.Text = iidd.ToString();
            Enrollmantnumber.Text = en.ToString();
            ContactNumber.Text = cont.ToString();
            FirstName.Text = fn;
            LastName.Text = ln;
            ClassName.Text = cn;
            Address.Text = an;
               
        }
    }
}
