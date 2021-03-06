using System;
using System.Collections.Generic;
using ProjectBase.Core.Model;

namespace ProjectBase.Data.Model
{
	[Serializable]
    public partial class HrDepart : IHrDepart
	{
        public HrDepart()
		{		
		}

        public virtual long Id { get; set; }
        public virtual string DeptTname { get; set; }
        public virtual string DeptEname { get; set; }
        public virtual System.Nullable<long> DeptIdx { get; set; }
        public virtual System.Nullable<long> DeptOrder { get; set; }
        public virtual string DeptGroup { get; set; }
	}
}