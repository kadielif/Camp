using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("elif");
            isimler.Add("esra");
            isimler.List();

            // ÖDEV

            Student student1 = new Student();
            student1.Name = "Elif";
            student1.Grade = 23;

            Student student2 = new Student();
            student2.Name = "Esra";
            student2.Grade = 23;

            MyDictionary<string,int> studentInfo = new MyDictionary<string,int>();
            studentInfo.Add(student1.Name,student1.Grade);
            studentInfo.Add(student2.Name,student2.Grade);

        }
    }
}
