using System.Text;

namespace CodingGameFilter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int width = 5; // the number of cells on the X axis
            int height = 1; // the number of cells on the Y axis
                            // Console.Error.WriteLine(width);
                            //Console.Error.WriteLine(height);
            //IList<string> lines = new List<string>() { "0.0.0" };
            IList<string> lines = new List<string>() { "0.0.0" };
            string res="";
            string nexti = "";
            string nextj = "";

            /* for (int i = 0; i < height; i++)
             {
               //  string line = Console.ReadLine(); // width characters, each either 0 or .
                // lines.Add(line);
                 // Console.Error.WriteLine(line);

             }*/


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    res = "";
                    if (lines[i][j] == '0')
                    {
                        res = j + " " + i;
                        int a = i;
                        while (nexti == "")
                        {
                            if (a >= height - 1)
                            {
                                nexti = "-1 -1";
                            }
                            else if (lines[a + 1][j] == '0')
                            {
                                nexti = j + " " + (a + 1);
                            }
                            else a++;
                        };

                        int b = j;
                        while (nextj == "")
                        {
                            if (b >= width - 1)
                            {
                                nextj = "-1 -1";
                            }
                            else if (lines[i][b + 1] == '0')
                            {
                                nextj = (b + 1) + " " + i;
                            }
                            else b++;
                        };
                        res += " " + nextj;
                        res += " " + nexti;
                        nexti = "";
                        nextj = "";
                        Console.WriteLine(res);
                    }

                }
            }
         
        }
    }
}
