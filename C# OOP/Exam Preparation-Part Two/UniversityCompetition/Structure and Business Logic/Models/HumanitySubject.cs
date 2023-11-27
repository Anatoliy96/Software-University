﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCompetition.Models
{
    public class HumanitySubject : Subject
    {
        private const double humanitySubjectRate = 1.15;

        public HumanitySubject(int id, string name)
            : base(id, name, humanitySubjectRate)
        {
        }
    }
}
