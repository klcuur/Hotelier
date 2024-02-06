using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;
		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}
		public void TDelete(Service item)
		{
			_serviceDal.Delete(item);
		}

		public Service TGetByID(int id)
		{
			return _serviceDal.GetByID(id);
		}

		public List<Service> TGetList()
		{
			return _serviceDal.GetList();
		}

		public void TInsert(Service item)
		{
			_serviceDal.Insert(item);
		}

		public void TUpdate(Service item)
		{
			_serviceDal.Update(item);
		}
	}
}
