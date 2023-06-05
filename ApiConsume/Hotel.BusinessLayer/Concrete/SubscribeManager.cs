using Hotel.DataAccessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Concrete
{
	public class SubscribeManager : ISubscribeDal
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public void Delete(Subscribe t)
		{
			_subscribeDal.Delete(t);
		}

		public Subscribe GetById(int id)
		{
			return _subscribeDal.GetById(id);
		}

		public List<Subscribe> GetList()
		{
			return _subscribeDal.GetList();
		}

		public void Insert(Subscribe t)
		{
			_subscribeDal.Insert(t);
		}

		public void Update(Subscribe t)
		{
			_subscribeDal.Update(t);
		}
	}
}
