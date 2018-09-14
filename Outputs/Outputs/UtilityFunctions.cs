using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Outputs
{
    public class ReportAction
    {
        public static void PositiveResults()
        {
            Ranorex.Report.Success("Sucessufuly performed");
        }

        public static void NegativResults(string Actual, string Hardcoded)
        {
            string ActualValue = "Actual Value is: " + Actual;
            Ranorex.Report.Error(ActualValue);

            string HardcodedValue = "Expected Value is: " + Hardcoded;
            Ranorex.Report.Error(HardcodedValue);
        }
    }

    public class ComparingValues
    {
        public static void Results(string Actual, string Hardcoded)
        {
            string[] ReadActualValues = File.ReadAllLines(Actual);
            string[] ReadHardcodecdValues = File.ReadAllLines(Hardcoded);

            int ActualValuesLenght = ReadActualValues.Length;
            int HardcodedValuesLenght = ReadHardcodecdValues.Length;

            bool bResultOk = true;

            for (int i = 0; i < HardcodedValuesLenght; i++)
            {
                bool bSpecialProcedure = (i==4) && (ReadHardcodecdValues[i].Equals("AllOutputTypes.mxy                                       2    Friday, September 14, 2018 11:10:53 AM"));
                if (bSpecialProcedure)
                    continue;

                bool bSpecialExportProcedure = (i == 1) && (ReadHardcodecdValues[i].Equals("DATE | 9 / 14 / 2018"));
                if (bSpecialExportProcedure)
                    continue;

                bool bSpecialExportProcedureTwo = (i == 2) && (ReadHardcodecdValues[i].Equals("TIME|15:36:30"));
                if (bSpecialExportProcedureTwo)
                    continue;

                bool bComparingLines = ReadActualValues[i].Equals(ReadHardcodecdValues[i]);

                if (!bComparingLines)
                {
                    
                    ReportAction.NegativResults(ReadActualValues[i], ReadHardcodecdValues[i]);

                    bResultOk = false;

                }             


            }
            if (bResultOk)
            {
                ReportAction.PositiveResults();
            }
        }
    }
}

