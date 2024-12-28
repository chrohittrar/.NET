using System;
using System.Collections.Generic;

namespace NewWeb.Models
{
    public partial class Emp10
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; }
        public DateOnly? Hiredate { get; set; }
        public decimal? Sal { get; set; }
        public decimal? Comm { get; set; }
        public int? Deptno { get; set; }
    }
}
