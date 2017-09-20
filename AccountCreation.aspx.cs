using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountCreation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AccountCreationButton_Click(object sender, EventArgs e)
    {
        var users = new UserDB(Server.MapPath("Config/") + @"Users.txt");

        if (!users.UserExists(AccountCreationUserName.Text))
        {
            UserAccount newUser = new UserAccount
            {
                userName = AccountCreationUserName.Text,
                email = AccountCreationEmail.Text,
                password = AccountCreationPassword.Text,
                funds = 0,
                status = 1
            };

            users.Adduser(newUser);
            users.Save();
            Session["CurrentUser"] = newUser;
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            //User already exists
        }
    }
}