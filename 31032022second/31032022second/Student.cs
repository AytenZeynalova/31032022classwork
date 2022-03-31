using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022second
{
    class Student:Person
    {
        public int IQRank;
        public int LanguageRank;

        public void ExamResult(int iqrank, int languagerank)
        {
            int examresult = 0;
            IQRank = iqrank;
            LanguageRank = languagerank;
            if(iqrank>=0&&iqrank<100)
            {
                if(languagerank>=0&& languagerank <= 100)
                {
                    examresult = iqrank + languagerank;
                    if (examresult > 120)
                    {
                        Console.WriteLine($"Exam result: {examresult}");
                    }
                    else
                    {
                        Console.WriteLine("sinifde qaldiniz!");
                    }
                    
                }
            }
            
        }

        public Student()
        {
               
        }
    }
}
