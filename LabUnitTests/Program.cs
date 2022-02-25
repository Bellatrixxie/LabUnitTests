using System;

namespace LabUnitTests
{
    public class Program
    {
        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 8)
            {
                result = "U films are available. PG films are available, Parent Guidance advised.";
            }
            else if (ageOfViewer < 12)
            {
                result = "U & PG films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }
    }
}