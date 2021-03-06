using System;
using System.Collections.Generic;
using ProjectBase.Core.Model;

namespace ProjectBase.Data.Model
{
	[Serializable]
    public partial class UaeProjectManage : IUaeProjectManage
	{
		public UaeProjectManage()
		{		
		}
		public virtual string ProjCode
		{
			get;
			set;
		}
		public virtual DateTime? ProjDateend
		{
			get;
			set;
		}
		public virtual DateTime? ProjDatestart
		{
			get;
			set;
		}
		public virtual string ProjDepartment
		{
			get;
			set;
		}
		public virtual string ProjEname
		{
			get;
			set;
		}
		public virtual DateTime? ProjExtent
		{
			get;
			set;
		}
		public virtual string Id
		{
			get;
			set;
		}
		public virtual string ProjTname
		{
			get;
			set;
		}
		public virtual double? ProjValue
		{
			get;
			set;
		}
        public virtual int? InctNum
        {
            get;
            set;
        }
        public virtual int? ProjYear
        {
            get;
            set;
        }
        public virtual string CreateBy
        {
            get;
            set;
        }
        public virtual DateTime? CreateDate
        {
            get;
            set;
        }
        public virtual string UpdateBy
        {
            get;
            set;
        }
        public virtual DateTime? UpdateDate
        {
            get;
            set;
        }
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as IUaeProjectManage);
		}
		
		public virtual bool Equals(IUaeProjectManage obj)
		{
			if (obj == null) return false;

			if (Equals(ProjCode, obj.ProjCode) == false) return false;
			if (Equals(ProjDateend, obj.ProjDateend) == false) return false;
			if (Equals(ProjDatestart, obj.ProjDatestart) == false) return false;
			if (Equals(ProjDepartment, obj.ProjDepartment) == false) return false;
			if (Equals(ProjEname, obj.ProjEname) == false) return false;
			if (Equals(ProjExtent, obj.ProjExtent) == false) return false;
            if (Equals(Id, obj.Id) == false) return false;
			if (Equals(ProjTname, obj.ProjTname) == false) return false;
			if (Equals(ProjValue, obj.ProjValue) == false) return false;
			if (Equals(ProjYear, obj.ProjYear) == false) return false;
            if (Equals(InctNum, obj.InctNum) == false) return false;
            if (Equals(CreateBy, obj.CreateBy) == false) return false;
            if (Equals(CreateDate, obj.CreateDate) == false) return false;
            if (Equals(UpdateBy, obj.UpdateBy) == false) return false;
            if (Equals(UpdateDate, obj.UpdateDate) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (ProjCode != null ? ProjCode.GetHashCode() : 0);
			result = (result * 397) ^ (ProjDateend != null ? ProjDateend.GetHashCode() : 0);
			result = (result * 397) ^ (ProjDatestart != null ? ProjDatestart.GetHashCode() : 0);
			result = (result * 397) ^ (ProjDepartment != null ? ProjDepartment.GetHashCode() : 0);
			result = (result * 397) ^ (ProjEname != null ? ProjEname.GetHashCode() : 0);
			result = (result * 397) ^ (ProjExtent != null ? ProjExtent.GetHashCode() : 0);
            result = (result * 397) ^ (Id != null ? Id.GetHashCode() : 0);
			result = (result * 397) ^ (ProjTname != null ? ProjTname.GetHashCode() : 0);
			result = (result * 397) ^ (ProjValue != null ? ProjValue.GetHashCode() : 0);
			result = (result * 397) ^ (ProjYear != null ? ProjYear.GetHashCode() : 0);
            result = (result * 397) ^ (InctNum != null ? InctNum.GetHashCode() : 0);
            result = (result * 397) ^ (CreateBy != null ? CreateBy.GetHashCode() : 0);
            result = (result * 397) ^ (CreateDate != null ? CreateDate.GetHashCode() : 0);
            result = (result * 397) ^ (UpdateBy != null ? UpdateBy.GetHashCode() : 0);
            result = (result * 397) ^ (UpdateDate != null ? UpdateDate.GetHashCode() : 0);
			return result;
		}
	}
}