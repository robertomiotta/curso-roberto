using System;

namespace Curso.Roberto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // meu primeiro projeto
            var parm = Console.ReadLine();
            int N = Convert.ToInt32(parm);
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
                Console.WriteLine(i + " " + ((i * i) + 1) + " " + ((i * i * i) + 1));
            }
            // meu segundo comentario
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " - Roberto");
            }

        }
    }
}

