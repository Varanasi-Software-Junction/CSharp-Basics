﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deposit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            lbl.Text = "";
            DataSet1TableAdapters.accountsTableAdapter da = new DataSet1TableAdapters.accountsTableAdapter();
          DataSet1.accountsDataTable dt=  da.GetDataByAccountNo(Convert.ToInt32(txtAccountNo.Text));
            if(dt.Rows.Count<=0)
            {
                throw new Exception("Invalid Account No");
            }
            DataSet1.accountsRow dr= (DataSet1.accountsRow)dt.Rows[0];
            lblName.Text = dr.name;
            lblBalance.Text = "" + dr.balance;
            Button2.Enabled = true;
            Button1.Enabled = false;
            txtAccountNo.ReadOnly = true;

        }
        catch (Exception ex)
        {
            lbl.Text = ex.Message;
            lblName.Text = "";
            lblBalance.Text = "" ;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToInt32(txtAmount.Text) <= 0)
                throw new Exception("Invalid Amount");

            DataSet1TableAdapters.accountsTableAdapter da = new DataSet1TableAdapters.accountsTableAdapter();
            da.deposit(Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtAccountNo.Text));
            lbl.Text = "Deposited";
            DataSet1.accountsDataTable dt = da.GetDataByAccountNo(Convert.ToInt32(txtAccountNo.Text));
            if (dt.Rows.Count <= 0)
            {
                throw new Exception("Invalid Account No");
            }
            DataSet1.accountsRow dr = (DataSet1.accountsRow)dt.Rows[0];
            lblName.Text = dr.name;
            lblBalance.Text = "" + dr.balance;
            Button2.Enabled = false;
        }
        catch (Exception ex)
        {
            lbl.Text = ex.Message;
        }
    }
}