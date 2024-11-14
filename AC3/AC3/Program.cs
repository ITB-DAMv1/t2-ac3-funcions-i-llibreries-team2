using System;

public class Program
{
    public static void Main()
    {
        // const 
        const string MsgErrorDades = "Les dades han sigut introduïdes incorrectament";
        const string MsgUserAvatar = "Tria el avatar!Has d'introduir un nombre entre 1 i 4.";
        const string MsgUserName = "Tria un nom, sense números, que com a mínim tingui 2 lletres i com màxim 25.";
        const string MsgMaldat = "Tria el teu nivell de maldat!Has d'introduir un nombre entre 1000 i 50000.";  
        const string MaldatInvalid = "El nivel de maldat no està entre 1000 i 50000";

        // var
        string userName;
        char[] userNameArray;   // antes era string[]
        int userAvatar = 0;
        int userMaldat = 0;
        bool flag = false;
        int polsMagica = 0;
        int numVocales = 0;
        char[] vocalesArray = new char[] { 'A', 'E', 'I', 'O', 'U' };   // antes estaba como constante

        // main
        // GameCore(userNameArray, vocalesArray, numVocales, flag, polsMagica, userMaldat);  // se pasan los parámetros

    }

    public static void GameCore(char[] userNameArray, char[] vocalesArray, int numVocales, bool flag, int polsMagica, int userMaldat)   // se pasan los parámetros
    {
        for (int i = 0; i < userNameArray.Length; i++)
        {
            for (int j = 0; j < vocalesArray.Length; j++) // he cambiado int n por int j
            {
                if (userNameArray[i] == vocalesArray[j])
                {
                    numVocales = numVocales + 1;
                }
            }
        }

        if (numVocales >= 2)
        {
            flag = true;
        }

        if (flag)
        {
            polsMagica = userMaldat / 4;
        }
        else
        {
            polsMagica = ((userMaldat * 5) / 100) / 4;
        }
    }
}