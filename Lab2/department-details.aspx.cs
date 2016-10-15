using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //connect the db
            var conn = new ContosoEntities();

            //use the Department class to create a new Department object from department.cs
            Department d = new Department();

            //fill the properties of the new department object
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            //save a new object to db
            conn.Departments.Add(d);
            conn.SaveChanges();

            //redirect to the department page
            Response.Redirect("departments.aspx");
        }
    }
}