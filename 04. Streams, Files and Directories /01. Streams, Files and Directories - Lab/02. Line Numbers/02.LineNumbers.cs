namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader inputStreamReader = new StreamReader(inputFilePath))
            {
                int row = 1;

                //Reading
                while (!inputStreamReader.EndOfStream)
                {
                    string currentText = inputStreamReader.ReadLine();

                    //Writing
                    using (StreamWriter outputStreamWriter = new StreamWriter(outputFilePath, true))
                    {
                        outputStreamWriter.WriteLine($"{row}. {currentText}");
                    }
                    row++;
                }
            };

        }
    }
}
