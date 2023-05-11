namespace /*insira o seu namespace aqui*/
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();
            HashSet<int> TotalAlunos = new HashSet<int>(CourseA);

            Console.Write("How many students for course A?  ");
            int QuantAlunosA = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            for (int i = 0; i < QuantAlunosA; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                CourseA.Add(aluno);
            }

            Console.Write("How many students for course B?  ");
            int QuantAlunosB = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantAlunosB; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                CourseA.Add(aluno);
            }

            Console.Write("How many students for course C?  ");
            int QuantAlunosC = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantAlunosC; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                CourseA.Add(aluno);
            }

            TotalAlunos.UnionWith(CourseB);
            TotalAlunos.UnionWith(CourseC);

            Console.WriteLine("Total students: " + TotalAlunos.Count);
        }
    }
}
