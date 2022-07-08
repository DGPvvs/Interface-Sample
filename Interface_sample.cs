using Interface_sample.CarClasses;
using Interface_sample.Contract;
using Interface_sample.ShapeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_sample
{
	class Interface_sample
	{
        static void Main()
        {
            List<IPerformance> objects = new List<IPerformance>();
            char[] splitArr = { ' ', ',', '(', ')' };

            bool isLoopExit = false;

            while (!isLoopExit)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    isLoopExit = true;
                }
                else
                {
                    IPerformance entity = null;
                    string[] task = input.Split(splitArr);

                    string objectType = task[0];

                    switch (objectType.ToLower())
                    {
                        case "triangle":
                            double a = double.Parse(task[1]);
                            double ha = double.Parse(task[2]);
                            string color = task[3];
                            entity = new Triangle(a, ha, color);
                            break;
                        case "cyrcle":
                            double radius = double.Parse(task[1]);
                            color = task[2];
                            entity = new Cyrcle(radius, color);
                            break;
                        case "rectangle":
                            a = double.Parse(task[1]);
                            double b = double.Parse(task[2]);
                            color = task[3];
                            entity = new Rectangle(a, b, color);
                            break;
                        case "volkswagen":
                            double hp = double.Parse(task[1]);
                            color = task[2];
                            entity = new Volkswagen(hp, color);
                            break;
                        case "opel":
                            hp = double.Parse(task[1]);
                            double rpm = double.Parse(task[2]);
                            color = task[3];
                            entity = new Opel(hp, rpm, color);
                            break;
                    }

                    objects.Add(entity);
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();

            foreach (IPerformance entity in objects)
            {
                sb.AppendLine(entity.Description()).AppendLine();                
            }


            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
