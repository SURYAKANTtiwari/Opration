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
using System.Data;

namespace Opration
{
    public partial class Form1 : Form
    {
        String connectionst = @"Data Source=DESKTOP-50MR975\nitin;Initial Catalog=ITSolutionTest;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Getdataformdatabase()
        {
            SqlConnection con = new SqlConnection(connectionst);
            con.Open();
            try
            {
                String Query = "select * from StudentTB";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult conferm = MessageBox.Show("Are you want to Delete","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (conferm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                    SqlConnection con = new SqlConnection(connectionst);
                    con.Open();
                    try
                    {
                        String Query = "delete from StudentTB where StudentID = @sid";
                        SqlCommand cmd = new SqlCommand(Query, con);
                        cmd.Parameters.AddWithValue("@sid", id);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Delete successfully");
                        }
                        else
                        {
                            MessageBox.Show("Data Not Deleted");
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
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int id, enroll, contact; String firstn, lastn, classn, addn;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                enroll = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Enrollmantnumber"].Value);
                firstn = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value);
                lastn= Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value);
                classn= Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ClassName"].Value);
                contact= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ContactNumber"].Value);
                addn = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Address"].Value);
                Form2 ff = new Form2(id,enroll,contact,firstn,lastn,classn,addn);
                ff.ShowDialog();

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Getdataformdatabase();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (isVaild())
            {
                int en, cont; String fn, ln, cn, an;
                en = Convert.ToInt32(EnrollNo.Text);
                cont = Convert.ToInt32(ContNo.Text);
                fn = SFN.Text;
                ln = SLN.Text;
                cn = SCN.Text;
                an = Saddress.Text;
                SqlConnection con = new SqlConnection(connectionst);
                con.Open();
                try
                {
                    String Query = "insert into StudentTB values (@enrolln,@fname,@lname,@class,@contn,@ad)";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@enrolln", en);
                    cmd.Parameters.AddWithValue("@fname", fn);
                    cmd.Parameters.AddWithValue("@lname", ln);
                    cmd.Parameters.AddWithValue("@class", cn);
                    cmd.Parameters.AddWithValue("@contn", cont);
                    cmd.Parameters.AddWithValue("@ad", an);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Save successfully");

                      
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    ReSetforms();
                }

            }
        }

        private bool isVaild()
        {
            if(SFN.Text == String.Empty)
            {
                MessageBox.Show("Student name is reqired", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ReSetforms();
        }

        private void ReSetforms()
        {
            SFN.Clear();
            SLN.Clear();
            EnrollNo.Clear();
            ContNo.Clear();
            SCN.Clear();
            Saddress.Clear();
        }
    }
}
