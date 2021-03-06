using System;
using System.Collections.Generic;
using ProjectBase.Core.Model;

namespace ProjectBase.Data.Model
{
	[Serializable]
    public partial class HrPosition : IHrPosition
	{
        public HrPosition()
		{		
		}

        public virtual long Id { get; set; }
        public virtual string PsTname { get; set; }
        public virtual string PsEname { get; set; }
        public virtual string PsComment { get; set; }
        public virtual string PsMn { get; set; }
        public virtual string PsIden { get; set; }		
	}
}