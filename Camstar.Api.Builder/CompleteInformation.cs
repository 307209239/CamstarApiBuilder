using System;

namespace Camstar.Api.Builder
{
    public class CompleteInformation
    {
        private WCFGeneratorException mException;

        internal CompleteInformation(int dCCount, int sCCount, TimeSpan generationTime)
        {
            IsSuccess = true;
            mException = (WCFGeneratorException) null;
            DCCount = dCCount;
            SCCount = sCCount;
            TotalElapsedTime = generationTime;
        }

        internal CompleteInformation(WCFGeneratorException exception)
        {
            IsSuccess = false;
            mException = exception;
            DCCount = 0;
            SCCount = 0;
            TotalElapsedTime = TimeSpan.MinValue;
        }

        public CompleteInformation SilverlightCompleteInformation { get; set; }

        public int DCCount { get; }

        public int SCCount { get; }

        public TimeSpan TotalElapsedTime { get; }

        public bool IsSuccess { get; }

        public WCFGeneratorException Exception => mException;

        public override string ToString()
        {
            string str;
            if (IsSuccess)
            {
                str = DCCount + " Data Contracts;\n" + SCCount + " Service Contracts;\n" +
                      TimeSpan.FromSeconds((int) TotalElapsedTime.TotalSeconds) + " Generation Time.\n";
                if (SilverlightCompleteInformation != null)
                    str = str + "Silverlight:\n" + SilverlightCompleteInformation.DCCount + " Data Contracts;\n" +
                          SilverlightCompleteInformation.SCCount + " Service Contracts;\n" +
                          TimeSpan.FromSeconds((int) SilverlightCompleteInformation.TotalElapsedTime.TotalSeconds) +
                          " Generation Time.\n";
            }
            else
            {
                str = mException.ToString();
            }

            return str;
        }
    }
}