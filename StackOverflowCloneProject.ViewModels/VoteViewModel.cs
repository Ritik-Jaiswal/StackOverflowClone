﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowCloneProject.ViewModels
{
    public class VoteViewModel
    {
        public int VoteID { get; set; }
        public int UserID { get; set; }
        public int AnswerID { get; set; }
        public int VoteValue { get; set; }
    }
}
