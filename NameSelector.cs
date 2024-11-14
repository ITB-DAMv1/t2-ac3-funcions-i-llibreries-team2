namespace Funcions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userNameArray="";
            //El userNameArray no és un array d'strings, ha de ser un array de chars o un string, a més el valor era nul i no podia entrar a la funció
            const string MsgUserName = "Tria un nom, sense números, que com a mínim tingui 2 lletres i com màxim 25.";
            string userName="";
            //El valor era nul i no podia entrar a la funció
            const string MsgErrorDades = "Les dades han sigut introduïdes incorrectament";
            NameSelector(MsgUserName, ref userName, MsgErrorDades, userNameArray);
            //El userNameArray no estava demanat per la variable
            //Referències i valors estaven al revés
        }
        public static void NameSelector(string MsgUserName, ref string userName, string MsgErrorDades, string userNameArray)
        {
            //Les variables estaven declarades al demanar la funció en comptes d'en la pròpia funció.
        Console.WriteLine(MsgUserName);
            do
            {
                userName=Console.ReadLine();
                if(!(userName.Length>=2 && userName.Length<=25))
                {
                    Console.WriteLine(MsgErrorDades);
                }
            } while (!(userName.Length >= 2 && userName.Length <= 25));
            //La condició estava invertida
            userNameArray = userName;
            //havien igualat al revès
        }
    }
}