﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    public interface IFuncionario: IImposto, ISalario
    {
        void Imprimir();
    }
}
