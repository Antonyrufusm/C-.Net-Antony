using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLR_Test
{
    class  PublicTest
    {
        public string name = "Antony Rufus";
        public void Message()
        {
            Console.WriteLine("Hello " + name);
        }
    }

    class ProtectedTest
    {
        protected string name = "Protected Message ";
        protected void Message()
        {
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
    class PrivateTest
    {
        private string Message = "This is a private message";

        public string GetMessage()
        {
            return Message;
        }
    }

    class AccessSpecifiers: ProtectedTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any access specifiers");
            Console.WriteLine("1.Public");
            Console.WriteLine("2.Private");
            Console.WriteLine("3.Protected");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PublicTest publicTest = new PublicTest(); 
                    publicTest.Message();
                    Console.ReadKey();
                    break;
                case 2:
                    PrivateTest privatetest = new PrivateTest();
                    string messageText = privatetest.GetMessage();
                    Console.WriteLine(messageText);
                    Console.ReadKey();
                    break;
                case 3:
                    AccessSpecifiers protectedTest = new AccessSpecifiers();
                    protectedTest.Message();
                    break;
            }
        }
    }
}
