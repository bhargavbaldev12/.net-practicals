using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace p2
{
    class P4
    {
        public static void Main() {
            Type T = Type.GetType("p2.Example");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();

            Console.WriteLine("\nProperties");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            Console.WriteLine("\nConstructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }
    }
    class Example {
        public string name { get; set; }
        public int enrollment { get; set; }
        public string branch { get; set; }

        public Example() { }
        public Example(int enrollment, string name) {
            this.enrollment = enrollment;
            this.name = name;
        }
        public Example(int enrollment, string name,string branch)
        {
            this.enrollment = enrollment;
            this.name = name;
            this.branch = branch;
        }
        public void displayName() {
            Console.WriteLine("Name={0}",this.name);
        }
        public void displayEnroll() {
            Console.WriteLine("Enrollment={0}",this.enrollment);
        }
        public void displayBranch()
        {
            Console.WriteLine("Branch={0}", this.branch);
        }


    }
}
