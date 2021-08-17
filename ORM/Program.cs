using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ORMContext ctx = new ORMContext())
            {
                Aluno a = new Aluno()
                {
                    Nome = "Christian",
                    Email = "chris@gmail.com"
                };

                ctx.Alunos.Add(a);
                ctx.SaveChanges();

                Console.WriteLine("Sucesso!");
                Console.ReadLine();
            }
        }
    }
}
