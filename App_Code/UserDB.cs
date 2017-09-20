using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.UI;
using Newtonsoft.Json;

public class UserDB
{
    public string filePath;
    public List<UserAccount> users;

    public UserDB(string path)
    {
        filePath = path;
        users = new List<UserAccount>();

        if (File.Exists(path))
        {
            foreach (string line in File.ReadLines(path, Encoding.UTF8))
            {
                // Generate accounts
                UserAccount acc = JsonConvert.DeserializeObject<UserAccount>(line);
                users.Add(acc);
            }

        }
    }

    public void Save()
    {
        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (UserAccount user in users)
                file.WriteLine(JsonConvert.SerializeObject(user));
        }
    }

    public bool UserExists(string userName)
    {
        foreach (UserAccount u in users)
        {
            if (string.Equals(u.userName, userName))
                return true;
        }

        return false;
    }


    public void Adduser(UserAccount newUser)
    {
        users.Add(newUser);
        Save();
    }

    public void AddFundsTo(string userName, float addedFunds)
    {
        foreach (UserAccount u in users)
        {
            if (string.Equals(u.userName, userName))
            {
                u.funds += addedFunds;
                Save();
            }
        }
    }

    public bool WithdrawFundsFrom(string userName, float withdrawAmmount)
    {
        foreach (UserAccount u in users)
        {
            if (string.Equals(u.userName, userName))
            {
                if (u.funds >= withdrawAmmount)
                {
                    u.funds -= withdrawAmmount;
                    Save();
                    return true;
                }
            }
        }
        return false;
    }

    public UserAccount GetUserByName(string userName)
    {
        foreach (UserAccount u in users)
        {
            if (string.Equals(u.userName, userName))
            {
                return u;
            }
        }
        return null;
    }

    public void RemoveUserByName(string userName)
    {
        UserAccount userToBeDeleted = GetUserByName(userName);

        if (userToBeDeleted != null)
            users.Remove(userToBeDeleted);
        Save();
    }
}

public class UserAccount
{
    public string userName;
    public string password;
    public string email;
    public float funds;
    public int status;

}