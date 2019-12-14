using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public List<Mark> Marks { get; set; }
        public Student()
        {
            Marks = new List<Mark>();
        }
        public override string ToString()
        {
            string rate = String.Empty;
            if (Marks != null)
            {
                foreach(var item in Marks)
                {
                    rate += (item as Mark).ToString()+Environment.NewLine; //\n
                }
            }
            return $"{Lastname} {Name}, {Age} {rate}";
        }
        public void AddMark(string subj, int mark)
        {
            if (!Marks.Exists(m => m.Subject.Equals(subj)))
            {
                Marks.Add(new Mark { Subject = subj, Rating = mark });
            }
        }
        
    }
    [Serializable]
    public class Mark { 
        public int Rating { get; set; }
        public string Subject{ get; set; }
        public override string ToString()
        {
            return $"{Subject}------------{Rating}";
        }
    }

    

}
