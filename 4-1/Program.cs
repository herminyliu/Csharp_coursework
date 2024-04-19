namespace _4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int id1 = Convert.ToInt32(Console.ReadLine());           
            string[] temp = Console.ReadLine().Split();
            int[] grades1 = new int[temp.Length];
            for (int i=0; i< temp.Length; i++)
            {
                grades1[i] = Convert.ToInt32(temp[i]);
            }
            int id2 = Convert.ToInt32(Console.ReadLine());            
            temp = Console.ReadLine().Split();
            int[] grades2 = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                grades2[i] = Convert.ToInt32(temp[i]);
            }
            Student s1 = new Student(id1, grades1);
            Student s2 = new Student(id2, grades2);
            Student.num = temp.Length;
            s1.Rank(ref grades1);
            s2.Rank(ref grades2);
            s1.Show();
            s2.Show();

        }
    }
    class Student
    {
        public int Id { get; set; }
        private int[] grades = new int[num];
        public static int num;
        public int[] Grades
        {
            get { return grades; }
            set { grades = value; }
        }
        public Student(int id, int[] grades)
        {
            Id = id;            
            Grades = grades;
        }
    
        public void Rank(ref int[] grades)
        {
            for(int i=0; i<grades.Length; i++)
            {
                for(int j = i + 1; j < grades.Length; j++)
                {
                    if(grades[i] > grades[j])
                    {
                        Swap(ref grades[i], ref grades[j]);
                    }
                }
            }
        }
        public void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2} {3}", Id, grades[0], grades[1], grades[2]);
        }
    }
}