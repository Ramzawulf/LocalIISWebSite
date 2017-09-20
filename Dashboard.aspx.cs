using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{
    private UserAccount currentUser
    {
        get
        {
            return (UserAccount) Session["CurrentUser"];
        }
        set { Session["CurrentUser"] = value; }
    }

    private UserDB myUsers;


    protected void Page_Load(object sender, EventArgs e)
    {
        myUsers = new UserDB(Server.MapPath("Config/") + @"Users.txt");
        
        if (currentUser != null && myUsers.UserExists(currentUser.userName))
        {
            UserNameLabel.Text = currentUser.userName;
            FundsAvailable.Text = currentUser.funds.ToString(CultureInfo.InvariantCulture);
        }
        else
        {
            //user information invalid redirect
            Response.Redirect("Default.aspx");
        }
    }

    protected void AddFundButton_Click(object sender, EventArgs e)
    {
        float addedFunds;
        if (float.TryParse(AddFundTextBox.Text, out addedFunds) && addedFunds > 0)
        {
            myUsers.AddFundsTo(currentUser.userName, addedFunds);
            currentUser = myUsers.GetUserByName(currentUser.userName);
            Reload();
        }
    }


    protected void LogOutButton_Click(object sender, EventArgs e)
    {
        currentUser = null;
        Reload();
    }


    private void Reload()
    {
        Response.Redirect("Dashboard.aspx");
    }

    protected void CloseAccountButton_Click(object sender, EventArgs e)
    {
        myUsers.RemoveUserByName(currentUser.userName);
        currentUser = null;
        Reload();
    }

    protected void WithdrawFundButton_Click(object sender, EventArgs e)
    {
        float withdrawAmmount;

        if (float.TryParse(WithdrawFundTextBox.Text, out withdrawAmmount))
        {
            myUsers.WithdrawFundsFrom(currentUser.userName, withdrawAmmount);
            currentUser = myUsers.GetUserByName(currentUser.userName);
            Reload();
        }

    }
}