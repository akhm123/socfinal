﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class JobRegistration : System.Web.UI.Page
    {
        JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JobPortalRef.CompanyDetails c = new JobPortalRef.CompanyDetails();
            c.Name = TextBox1.Text;
            c.Postname = TextBox2.Text;
            c.Jobid = TextBox3.Text;
            c.Qualification = TextBox4.Text;
            c.Salary = TextBox5.Text;
            c.Description = TextBox6.Text;
            c.Vacancy = Int32.Parse(TextBox7.Text);
            s.InsertData(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string p="";
            //var d = s.GetCompanyData();
            //for (int i = 0; i < d.Length; i++)
            //{
            //    p+=d[i].Item1.ToString(); //the int
            //    p+=d[i].Item2; //the string
            //    p+=(d[i].Item3); //the int       
            //}
            //Label1.Text = p;
        }
    }
}