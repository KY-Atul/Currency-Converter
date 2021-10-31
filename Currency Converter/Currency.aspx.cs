using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Currency_Converter
{
    public partial class Currency : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection("data source=HP\\SQLEXPRESS; initial catalog=currency; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display_curr_from();
                clear_all();
                ddlto.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

        public void display_curr_from()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("display_currency", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlfrom.DataSource = dt;
            ddlfrom.DataValueField = "id";
            ddlfrom.DataTextField = "curr_name";
            ddlfrom.DataBind();
            cnn.Close();
            ddlfrom.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        public void display_curr_to()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("display_currency", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlto.DataSource = dt;
            ddlto.DataValueField = "id";
            ddlto.DataTextField = "curr_name";
            ddlto.DataBind();
            cnn.Close();
            ddlto.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        public void display_prev()
        {
            SqlCommand cmd = new SqlCommand("display_prev_conversions", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grd.DataSource = dt;
            grd.DataBind();
            cnn.Close();
        }

        public void clear_all()
        {
            ddlfrom.SelectedValue = "0";
            ddlto.SelectedValue = "0";
            txtfrom.Text = "";
            txtto.Text = "";
            lblonoff.Text = "Off";
            lblonoff.ForeColor = System.Drawing.Color.Red;
        }


        protected void ddlfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_curr_to();

            if (ddlfrom.SelectedValue == "1")
                lblfrom.Text = "INR";
            else if (ddlfrom.SelectedValue == "2")
                lblfrom.Text = "USD";
            else if (ddlfrom.SelectedValue == "3")
                lblfrom.Text = "GBP";
            else if (ddlfrom.SelectedValue == "4")
                lblfrom.Text = "JPY";
            else
                lblfrom.Text = "";

        }

        protected void ddlto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlto.SelectedValue == "1")
                lblto.Text = "INR";
            else if (ddlto.SelectedValue == "2")
                lblto.Text = "USD";
            else if (ddlto.SelectedValue == "3")
                lblto.Text = "GBP";
            else if (ddlto.SelectedValue == "4")
                lblto.Text = "JPY";
            else
                lblto.Text = "";
        }

        protected void btnconvert_Click(object sender, EventArgs e)
        {
            if (ddlfrom.SelectedValue == "1" && ddlto.SelectedValue == "1")
            {
                txtto.Text = txtfrom.Text;
            }
            else if (ddlfrom.SelectedValue == "1" && ddlto.SelectedValue == "2")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 0.01358).ToString();
            }
            else if (ddlfrom.SelectedValue == "1" && ddlto.SelectedValue == "3")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text)*0.00982).ToString();
            }
            else if (ddlfrom.SelectedValue == "1" && ddlto.SelectedValue == "4")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text)*1.49).ToString();
            }
            //-----------------------------------------------------------------------------

            if (ddlfrom.SelectedValue == "2" && ddlto.SelectedValue == "1")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 73.4809).ToString();
            }
            else if (ddlfrom.SelectedValue == "2" && ddlto.SelectedValue == "2")
            {
                txtto.Text = txtfrom.Text;
            }
            else if (ddlfrom.SelectedValue == "2" && ddlto.SelectedValue == "3")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 0.72296).ToString();
            }
            else if (ddlfrom.SelectedValue == "2" && ddlto.SelectedValue == "4")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 110.01).ToString();
            }

            //------------------------------------------------------------------------------------

            if (ddlfrom.SelectedValue == "3" && ddlto.SelectedValue == "1")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 101.625).ToString();
            }
            else if (ddlfrom.SelectedValue == "3" && ddlto.SelectedValue == "2")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 1.38301).ToString();
            }
            else if (ddlfrom.SelectedValue == "3" && ddlto.SelectedValue == "3")
            {
                txtto.Text = txtfrom.Text;
            }
            else if (ddlfrom.SelectedValue == "3" && ddlto.SelectedValue == "4")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 152.15).ToString();
            }

            //----------------------------------------------------------------------------------

            if (ddlfrom.SelectedValue == "4" && ddlto.SelectedValue == "1")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 0.66787).ToString();
            }
            else if (ddlfrom.SelectedValue == "4" && ddlto.SelectedValue == "2")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 0.00909).ToString();
            }
            else if (ddlfrom.SelectedValue == "4" && ddlto.SelectedValue == "3")
            {
                txtto.Text = (Convert.ToDouble(txtfrom.Text) * 0.00657).ToString();
            }
            else if (ddlfrom.SelectedValue == "4" && ddlto.SelectedValue == "4")
            {
                txtto.Text = txtfrom.Text;
            }
            else
            {
                if (ddlfrom.SelectedValue == "0")
                {
                    lblfrom.Text = "Please select a currency";
                }

                if (ddlto.SelectedValue == "0")
                {
                    lblto.Text = "Please select a currency";
                }
            }

            //----------------------------------------------------------------------------------
            if ((ddlfrom.SelectedValue != "0" && ddlto.SelectedValue != "0") && (ddlfrom.SelectedValue!=ddlto.SelectedValue))
            {
                cnn.Open();
                SqlCommand cmdinsert = new SqlCommand("insert_conversion", cnn);
                cmdinsert.CommandType = CommandType.StoredProcedure;
                cmdinsert.Parameters.AddWithValue("@from_curr", ddlfrom.SelectedValue);
                cmdinsert.Parameters.AddWithValue("@to_curr", ddlto.SelectedValue);
                cmdinsert.Parameters.AddWithValue("@converted_value", Convert.ToDouble(txtto.Text));
                cmdinsert.Parameters.AddWithValue("@input_curr", Convert.ToDouble(txtfrom.Text));
                cmdinsert.ExecuteNonQuery();
            }


            //----------------------------------------------------------------------------------------------
            if (lblonoff.Text=="On")
            {
                display_prev();
            }
          
        }

        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "_delete_")
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("delete_record", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@delete_id", e.CommandArgument);
                cmd.ExecuteNonQuery();
                cnn.Close();
                display_prev();
            }
            else if (e.CommandName == "_redo_")
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("edit_values", cnn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@edit_id", e.CommandArgument);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblfrom.Text = dt.Rows[0]["curr_name"].ToString();
                lblto.Text = dt.Rows[0]["curr_name2"].ToString();
                txtfrom.Text = dt.Rows[0]["input_curr"].ToString();
                txtto.Text = dt.Rows[0]["converted_value"].ToString();
                cnn.Close();
                display_prev();

            }
        }

        protected void btnclr_Click(object sender, EventArgs e)
        {
            clear_all();
            grd.DataSource = null;
            grd.DataBind();
            lblfrom.Text = "";
            lblto.Text = "";
        }

        protected void btnprevious_Click(object sender, EventArgs e)
        {
            display_prev();
            lblonoff.Text = "On";
            lblonoff.ForeColor=System.Drawing.Color.Green;
        }
    }
}