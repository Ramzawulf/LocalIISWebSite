using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    protected void LogInButton_Click(object sender, EventArgs e)
    {
        var users = new UserDB(Server.MapPath("Config/") + @"Users.txt");
        if(string.IsNullOrEmpty(UserNameTextBox.Text))
            Response.Redirect("Default.aspx");

        foreach (UserAccount u in users.users)
        {
            if (string.Equals(u.userName, UserNameTextBox.Text))
            {
                Session["CurrentUser"] = u;
                Response.Redirect("Dashboard.aspx");
            }
        }
    }
}