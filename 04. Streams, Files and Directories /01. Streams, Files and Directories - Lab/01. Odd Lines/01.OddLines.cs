namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int row = 0;

                //Reading
                while (!reader.EndOfStream)
                {
                    string currentRow = reader.ReadLine();

                    //Writing
                    using (StreamWriter writer = new StreamWriter(outputFilePath, true))
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                        }
                    }
                    row++;
                }
            }
        }
    }
}
