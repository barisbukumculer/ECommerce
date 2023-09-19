﻿using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repositories;
using ECommerce.EntityLayer.Concrete;

namespace ECommerce.DataAccessLayer.EntityFramework
{
	public class EfOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
	{
		public EfOrderDetailDal(Context context) : base(context)
		{
		}
	}


}
