using Hotel.DataAccessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Concrete
{
	public class StaffManager : IStaffDal
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void Delete(Staff t)
		{
			_staffDal.Delete(t);
		}

		public Staff GetById(int id)
		{
			return _staffDal.GetById(id);
		}

		public List<Staff> GetList()
		{
			return _staffDal.GetList();
		}

		public void Insert(Staff t)
		{
			_staffDal.Insert(t);
		}

		public void Update(Staff t)
		{
			_staffDal.Update(t);
		}
	}
}
