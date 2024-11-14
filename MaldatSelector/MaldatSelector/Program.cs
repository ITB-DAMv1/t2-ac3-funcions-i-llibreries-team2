using System;

public class Program
{
    public static void Main()
    {
        string MsgMaldat ="Tria el teu nivell de maldat!Has d'introduir un nombre entre 1000 i 50000.";
        string MaldatInvalid ="El nivel de maldat no està entre 1000 i 50000";
        int maldad = 0;
        MaldatSelector(ref maldad, ref MsgMaldat, ref MaldatInvalid);
        Console.WriteLine( maldad );
    }

    public static void MaldatSelector(ref int userMaldat, ref string MsgMaldat, ref string MaldatInvalid)
    {        
        Console.WriteLine(MsgMaldat);
        userMaldat = int.Parse(Console.ReadLine());


        while ((userMaldat > 50000) && (userMaldat < 1000))
        {
            Console.WriteLine(MaldatInvalid);
            userMaldat = int.Parse(Console.ReadLine());
        }
    }
}