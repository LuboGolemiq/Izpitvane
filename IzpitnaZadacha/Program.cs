using System.Threading.Channels;

namespace IzpitnaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] grades = new int[26];

           
            EnterGradesForFirstGroup(grades);

          
            int myGrade = grades[MyNumber() - 1];
            Console.WriteLine($"Оценката на Вашия номер : {myGrade}");

           
            Console.WriteLine("Номерата на учениците със оценка 'СЛАБА' са:");
            List<int> weakGradesIndexes = GetWeakGradesIndexes(grades);
            foreach (int index in weakGradesIndexes)
            {
                Console.WriteLine(index + 1);
            }

            
            Console.WriteLine($"Последният елемент на масива е: {grades[grades.Length - 1]}");

           
            List<int> lowerGrades = GetLowerGrades(grades, myGrade);
            Console.WriteLine("Оценки по-малки от Вашата:");
            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }
        }

        
        static void EnterGradesForFirstGroup(int[] grades)
        {
            for (int i = 0; i < 13; i++)
            {
                Console.Write($"Въведете оценка за ученик {i + 1}: ");
               
                int grade;
                while (!int.TryParse(Console.ReadLine(), out grade) || grade < 2 || grade > 6)
                {
                    Console.WriteLine("Моля, въведете валидна оценка между 2 и 6.");
                    Console.Write($"Въведете оценка за ученик {i + 1}: ");
                }
                grades[i] = grade;
            }
        }

        
        static int MyNumber()
        {
            return 7; 
        }

        
        static List<int> GetWeakGradesIndexes(int[] grades)
        {
            List<int> weakIndexes = new List<int>();
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 2)
                {
                    weakIndexes.Add(i);
                }
            }
            return weakIndexes;
        }

        
        static List<int> GetLowerGrades(int[] grades, int myGrade)
        {
            List<int> lowerGrades = new List<int>();
            foreach (int grade in grades)
            {
                if (grade < myGrade)
                {
                    lowerGrades.Add(grade);
                }
            }
            return lowerGrades;
        }
    }
}

    


