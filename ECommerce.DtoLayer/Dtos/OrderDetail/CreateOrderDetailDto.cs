﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DtoLayer.Dtos.OrderDetail
{
	public record CreateOrderDetailDto(int OrderId,int ProductId, int Quantity, decimal UnitPrice);
}
