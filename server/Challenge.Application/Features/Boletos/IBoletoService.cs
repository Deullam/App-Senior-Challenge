﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Application.Features.Boletos
{
    public interface IBoletoService
    {

        public BoletoViewModel GetBoletoDetails(string bar_code);
    }
}
