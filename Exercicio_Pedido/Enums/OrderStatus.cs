﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pedido.Enums
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
