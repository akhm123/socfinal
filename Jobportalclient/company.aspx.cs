﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class company : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("JobPosting.aspx");


        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("ViewByCompany.aspx");


        }
        protected void Button3_Click(object sender, EventArgs e)
        {

            Response.Redirect("ViewByCompany.aspx");


        }
        protected void Button4_Click(object sender, EventArgs e)
        {

            Response.Redirect("UpdatePostedJob.aspx");


        }
    }
}