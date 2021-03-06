using System;

namespace GraduationCore.Common.Models.ViewModels
{
    public class IdNumber
    {
        //622426 1996 0408 2718
        public IdNumber(string _idNum)
        {
            idNum = _idNum;
        }
        private string idNum;
        public string IdNum
        {
            get { return idNum; }
        }

        public int Year
        {
            get { return int.Parse(idNum.Substring(6, 4)); }
        }

        public int Month
        {
            get { return int.Parse(idNum.Substring(10, 2)); }
        }
        public int Day
        {
            get { return int.Parse(idNum.Substring(12, 2)); }
        }

        public int Sex
        {
            get
            {
                int num = int.Parse(idNum.Substring(16, 1));
                if (num % 2 == 0)
                    return 0;
                else
                    return 1;
            }
        }

        public string BirthDay
        {
            get
            {
                return $"{Year}-{Month}-{Day}";
            }
        }

        public int IsLocal
        {
            get; set;
        }
    }
}