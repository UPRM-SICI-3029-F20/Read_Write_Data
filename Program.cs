using System.IO;  // required for Streamwriter
using static System.Console;

namespace Read_Write_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo -- Write to & Read from text files");

            // EXAMPLE #1 *************************************************************************
            WriteLine("Example 1 -- Write/save lines of text to file");
            StreamWriter myOutputFile;  // create an instance (object) of StreamWriter

            // CreateText: Writes to a newly created textfile or opens & OVERWRITES the existing file.
            myOutputFile = File.CreateText("C:\\Users\\Jose\\Desktop\\App_Data\\Voto2020.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1

            // WriteLine is the counterpart of ReadLine
            myOutputFile.WriteLine("Pedro Pierluisi – PNP");  // similar to Console.WriteLine
            myOutputFile.WriteLine("Carlos Delgado – PPD");
            myOutputFile.WriteLine("Juan Dalmau – PIP");
            myOutputFile.WriteLine("Alexandra Lúgaro – MVC");
            myOutputFile.WriteLine("César Vázquez – PD");
            myOutputFile.WriteLine("Eliezer Molina – Ind.");
            myOutputFile.WriteLine("Wanda Vázquez - Write-in");
            myOutputFile.WriteLine("Source: https://es.wikipedia.org/wiki/Elecciones_generales_de_Puerto_Rico_de_2020");

            // IMPORTANT: --> you need to close the file!
            myOutputFile.Close();
            WriteLine("Data written to file");



            // EXAMPLE #2 *************************************************************************
            WriteLine("Example 2 -- Append lines of text to file with DELIMITER");
            // AppendText: Appends text to existing file, creates the file if it does not exist
            StreamWriter myOutputFile2 = File.AppendText("C:\\Users\\Jose\\Desktop\\App_Data\\GradesEx2.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1


            // Write is the counterpart of Read
            const string DELIMITER = ", ";
            // The following statements outputs/writes the following line:  "Peter, 70, 80, 90, 70, 90" 
            myOutputFile2.Write("Peter" + DELIMITER);
            myOutputFile2.Write(70 + DELIMITER);
            myOutputFile2.Write(80 + DELIMITER);
            myOutputFile2.Write(90 + DELIMITER);
            myOutputFile2.Write(70 + DELIMITER);
            myOutputFile2.Write(90);

            myOutputFile2.WriteLine(); // Start a new line

            myOutputFile2.Write("Sally" + DELIMITER);
            myOutputFile2.Write(80 + DELIMITER);
            myOutputFile2.Write(85 + DELIMITER);
            myOutputFile2.Write(90 + DELIMITER);
            myOutputFile2.Write(80 + DELIMITER);
            myOutputFile2.Write(90);

            myOutputFile2.WriteLine(); // Start a new line

            myOutputFile2.Write("Diego" + DELIMITER);
            myOutputFile2.Write(99 + DELIMITER);
            myOutputFile2.Write(88 + DELIMITER);
            myOutputFile2.Write(77 + DELIMITER);
            myOutputFile2.Write(88 + DELIMITER);
            myOutputFile2.Write(99);

            myOutputFile2.WriteLine(); // Start a new line

            myOutputFile2.Close();
            WriteLine("Data written to file");



            // EXAMPLE #3 *************************************************************************
            WriteLine("Example 3 -- Append lines of text to file without DELIMITER");            ///
            // AppendText: Appends text to existing file, creates the file if it does not exist
            StreamWriter myOutputFile3 = File.AppendText("C:\\Users\\Jose\\Desktop\\App_Data\\GradesEX3.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1

            // WriteLine is the counterpart of ReadLine
            // The following statements outputs/writes each item on a separate line.
            myOutputFile3.WriteLine("Peter");
            myOutputFile3.WriteLine(70);
            myOutputFile3.WriteLine(80);
            myOutputFile3.WriteLine(90);
            myOutputFile3.WriteLine(70);
            myOutputFile3.WriteLine(90);

            myOutputFile3.WriteLine("Sally");
            myOutputFile3.WriteLine(80);
            myOutputFile3.WriteLine(85);
            myOutputFile3.WriteLine(90);
            myOutputFile3.WriteLine(80);
            myOutputFile3.WriteLine(90);

            myOutputFile3.WriteLine("Diego");
            myOutputFile3.WriteLine(99);
            myOutputFile3.WriteLine(88);
            myOutputFile3.WriteLine(77);
            myOutputFile3.WriteLine(88);
            myOutputFile3.WriteLine(99);

            myOutputFile3.Close();
            WriteLine("Data written to file");



            // EXAMPLE #4 *************************************************************************
            WriteLine("Example 4 -- Read and display lines from txt file");
            // variable to store each line of text to be read/input form the file
            string lineOfInput;

            StreamReader myInputFile;
            myInputFile = File.OpenText("C:\\Users\\Jose\\Desktop\\App_Data\\Voto2020.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1

            // Read & Display first line of text
            lineOfInput = myInputFile.ReadLine();  // similar to Console.Readline()
            WriteLine(lineOfInput);

            // Read & Display next line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);

            // Read & Display next line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);

            // Read & Display next line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);

            // Read & Display next line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);

            // Read & Display next line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);

            // Read & Display 7th and final line of text
            lineOfInput = myInputFile.ReadLine();
            WriteLine(lineOfInput);



            // EXAMPLE #5 *************************************************************************
            WriteLine("Example 5 -- Read and display all lines until end-of-file");
            // variable to store line of text to be read form the file
            string lineOfInput2;

            StreamReader myInputFile2;
            myInputFile2 = File.OpenText("C:\\Users\\Jose\\Desktop\\App_Data\\GradesEx2.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1

            // Read & Display all lines of text
            while (!myInputFile2.EndOfStream)
            {
                lineOfInput2 = myInputFile2.ReadLine();  // similar to Console.Readline()
                WriteLine(lineOfInput2);
            }



            // EXAMPLE #6 *************************************************************************
            WriteLine("Example 6 -- Read and display all lines until end-of-file");
            // variable to store line of text to be read form the file
            string lineOfInput3;

            StreamReader myInputFile3;
            myInputFile3 = File.OpenText("C:\\Users\\Jose\\Desktop\\App_Data\\GradesEx3.txt");
            // Edit the above path according to your environment.
            // Note: Rememeber, if no path is indicated the files are saved in the bin/debug/netcoreapp3.1

            // Read & Display all lines of text
            while (!myInputFile3.EndOfStream)
            {
                lineOfInput3 = myInputFile3.ReadLine();  // similar to Console.Readline()
                WriteLine(lineOfInput3);
            }
        }
    }
}
