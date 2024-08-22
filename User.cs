class User
{
    private string name;
    private string pass;

    public User(string _name, string _pass)
    {
        this.name = _name;
        this.pass = _pass;
    }

    public string getName()
    {
        return name;
    }

    public string getPass()
    {
        return pass;
    }

}