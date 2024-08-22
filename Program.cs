//Excercício sistema de login
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Login();
    }
    
    public static void Login()
    {
        Console.WriteLine("Bem vindo ao sistema!");

        Console.WriteLine("Digite seu nome de usuário: ");
        string username;
        username = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string pass;
        pass = Console.ReadLine();

        User userTemp = new User(username, pass);

        //Simulação de usuários cadastrados
        ArrayList userList = new ArrayList();
        User user1 = new User("Pedro", "123321");
        userList.Add(user1);

        User user2 = new User("Roger", "roger");
        userList.Add(user2);
        //Fim

        foreach(var user in userList)
        {
            //Valida se var é do tipo User e cria uma variável chamada userObjeto (userObjeto é igual a user)
            if(user is User userObjeto)
            {                
                if(userTemp.getName().Equals(userObjeto.getName()) && userTemp.getPass().Equals(userObjeto.getPass()))
                {
                    Console.WriteLine("Login autorizado!");
                    return;
                }
            }
            continue;
        }

        Console.WriteLine("Nome de usuário ou senha incorretos!");
    }
}
