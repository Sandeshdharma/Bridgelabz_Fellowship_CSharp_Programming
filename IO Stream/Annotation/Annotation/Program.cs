using AnnotationDemo;
using SimpleAnnotationDemo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace Annotation
{
    internal class Program
    {
        public static void Main()
        //{
        //    Obsolete Ob = new Obsolete();
        //    Ob.oldMethod();
        //    Console.ReadLine();
        //}

        //{
        //    oldApi api = new oldApi();


        //    Console.WriteLine(" Calling New Feature ");
        //    api.NewFeature();

        //    Console.WriteLine(" Calling Old Feature ");
        //    api.OldFeature();


        //    Console.ReadLine();
        //}

        //{
        //    Student s = new Student();
        //    s.setDetails(1, "sandesh", 92.3);
        //    Console.WriteLine("Student Details");
        //    Console.WriteLine("Roll number: " + s.getRollNo);
        //    Console.WriteLine("Name" + s.getStuname);
        //    Console.WriteLine("marks" + s.getmarks);
        //}


        {


            Type type = typeof(FeatureManager);
            FeatureManager manager = new FeatureManager();

          
            foreach (MethodInfo method in type.GetMethods())
            {
                
                StatusAttribute status = method.GetCustomAttribute<StatusAttribute>();

                if (status != null)
                {
                    Console.WriteLine("Found Method: {method.Name}()");
                    Console.WriteLine("Status Tag:   [{status.Stage}]");

                    
                    if (status.Stage == "Experimental")
                    {
                        Console.WriteLine("Running unapproved test code");
                    }

                 
                    method.Invoke(manager, null);
                    Console.WriteLine(new string('-', 35));
                }
            }
        }
    }





    }
}






