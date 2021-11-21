using System;

namespace _8_Studio_Counting_Characters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*string myStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";*/

            //Console.WriteLine("String: " + myStr);

            Console.WriteLine("Please enter your string: \n");

            string myStr = Console.ReadLine();

            while (myStr.Length > 0)

            {
                Console.Write(myStr[0] + " = ");

                int count = 0;

                for (int j = 0; j < myStr.Length; j++)

            {
                    if (myStr[0] == myStr[j])

                    {

                        count++;

                    }

                }

                Console.WriteLine(count);

                myStr = myStr.Replace(myStr[0].ToString(), string.Empty);
            }

            Console.ReadLine();

        }
    }
}

