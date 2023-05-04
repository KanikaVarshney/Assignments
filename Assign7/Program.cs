namespace Assign7
{
    internal class Program
    {
        public static void Main()
        {
            {
                // Console.WriteLine("Started");
                // if(Directory.Exists("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1"));
                //Directory.CreateDirectory("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo");
                ////Directory.CreateDirectory("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\demo1");
                //Directory.CreateDirectory("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\demo2");

                //File.Create("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\kanika.txt");

                //FileInfo fs = new FileInfo("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\varshney.txt");
                //fs.Create();


                //string str = "My name is kanika varshney";
                //File.AppendAllText("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\kanika.txt", str);

                // string strr = "My name is kanika varshney";
                // File.AppendAllText("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\varshney.txt", strr);

                //File.CopyTo("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\demo2\\kanika.txt");
                //File.Delete();
                //File.Copy("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\varshney.txt", "C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo\\demo1");
                //string[] list = Directory.GetDirectories("C:\\Users\\Kanika.Varshney\\source\\repos\\Assignment1\\demo");
                //foreach (string item in list)
                //{
                //   Console.WriteLine(item);
                //}
                //Console.WriteLine(Directory.GetCreationTime(""));

                //Console.WriteLine("FileStream");
                //FileStream fs = new FileStream(@"C:\Users\Kanika.Varshney\source\repos\Assignment1\kanikavarshney.txt", FileMode.Append, FileAccess.Write);
                //StreamWriter writer = new StreamWriter(fs);

                //writer.WriteLine("Hello! I am Kanika");
                //writer.Close();
                //fs.Close();
                //fs = new FileStream(@"C:\Users\Kanika.Varshney\source\repos\Assignment1\kanikavarshney.txt",FileMode.Open,FileAccess.Read);
                //StreamReader reader = new StreamReader(fs);
                //Console.WriteLine(reader.ReadToEnd());

                //reader.Close();

                FileStream fs = new FileStream(@"C:\Users\Kanika.Varshney\source\repos\Assignment1\kanikavarshney.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                string ch = "y";
                string name = null;
                while (ch == "y")
                {
                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();
                    writer.WriteLine(name);
                    Console.WriteLine("Add moew ");
                    ch = Console.ReadLine();
                }
                writer.Close();
                fs.Close();


            }


        }
    }
}