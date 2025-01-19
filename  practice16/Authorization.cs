class Authorization 
{
     public bool IsAuthorized(string username, string password)
        {
            return (username == "admin" && password == "passw0rd");
        }


}