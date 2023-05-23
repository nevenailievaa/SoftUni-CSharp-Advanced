namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (var firstTextReader = new StreamReader(firstInputFilePath))
            {
                using (var secondTextReader = new StreamReader(secondInputFilePath))
                {
                    using (var writer = new StreamWriter(outputFilePath))
                    {
                        string line1 = string.Empty;
                        string line2 = string.Empty;

                        while ((line1 = firstTextReader.ReadLine()) != null && (line2 = secondTextReader.ReadLine()) != null)
                        {
                            if (line2 != null)
                            {
                                writer.WriteLine(line1);
                            }

                            if (line1 != null)
                            {
                                writer.WriteLine(line2);
                            }
                        }
                    }
                }
            }
        }
    }
}
