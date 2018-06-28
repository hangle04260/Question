using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic.Business.Model
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int QuestionNumber { get; set; }
        public int DepartmentID { get; set; }
        public string QuestionName { get; set; }
        public int AnwserNumber { get; set; }

        public bool IsImage { get; set; }
        public string ImagePath { get; set; }

        public string ResultFirstText { get; set; }
        public string ResultSecondText { get; set; }
        public string ResultThirdText { get; set; }
        public string ResultFourText { get; set; }

        public bool IsResultFirst { get; set; }
        public bool IsResultSecond { get; set; }
        public bool IsResultThird { get; set; }
        public bool IsResultFour { get; set; }
    }
}
