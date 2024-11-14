using System;
namespace FuncionJhonGp2
{
    public class FuncionJhonGp2
    {
        public static void Main()
        {
            int userAvatar = 0;
            const string MsgUserAvatar = "Tria el avatar!Has d'introduir un nombre entre 1 i 4.";
            //Quitamos STRING Ya que userAvatar ya esta inicializado. 
            // AvatarSelector(string userAvatar by ref, string MsgUserAvatar by ref);
            AvatarSelector(ref userAvatar, MsgUserAvatar);
        }
        public static void AvatarSelector(ref int userAvatar, string MsgUserAvatar)
        {
            Console.WriteLine(MsgUserAvatar);

            //añadidos parentesis externos para que funcione while !(userAvatar >= 1 && userAvatar <= 4)
            while (!(userAvatar >= 1 && userAvatar <= 4))
            {
                userAvatar = int.Parse(Console.ReadLine());
            }
        }
    }
}
