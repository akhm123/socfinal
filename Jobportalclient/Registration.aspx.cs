﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
            JobPortalRef.User u = new JobPortalRef.User();
            u.UserName = TextBox1.Text;
            u.Email = TextBox2.Text;
            u.Password = TextBox3.Text;
            u.Contact = TextBox5.Text;
            u.Role = TextBox6.Text;
            
            string st = s.AddUser(u);
            
                Response.Redirect("Login.aspx");
            


        }
    }
}