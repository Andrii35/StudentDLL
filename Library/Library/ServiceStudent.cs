using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
     public class ServiceStudent
    {
        private string path = "student.db";
        public  IEnumerable<Student> Students { get; set; }
        public void AddS(Student st)
        {
            (Students as List<Student>).Add(st);
        }
        public void Remove(string Lastname)
        {
            List<Student>temp= Students as  List<Student>;
            temp.Remove(temp.Find(st => st.Lastname.Equals(Lastname)));
        }
        public ServiceStudent()
        {
            if (!File.Exists(path))
                Students = new List<Student>();
            else
            {
                Load();
            }
        }
        private void Load()
        {
            using(FileStream fs=new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Students=(List<Student>)bf.Deserialize(fs);

            }
        }

        public void Save()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs,Students);

            }
        }

    }
}
