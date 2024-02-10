public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public User()
    {
        
    }
    public User(int userid,string username)
    {
        UserId = userid;
        UserName = username;
    }
}