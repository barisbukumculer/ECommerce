﻿using ECommerce.DtoLayer.Dtos.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DtoLayer.Dtos.Order
{
	public record CreateOrderDto(string UserId, List<CreateOrderDetailDto> OrderDetails);
}
