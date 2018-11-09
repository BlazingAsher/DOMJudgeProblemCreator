using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMJudgeProblemCreator
{
    public class Problem
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public long MaxMemory { get; set; }
        public double MaxTime { get; set; }
        public string HexColour { get; set; }
        public string ProblemStatementPath { get; set; }
        public List<string[]> TestCases { get; set; }
    }
}
