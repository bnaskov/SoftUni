﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKK
{
    public interface IWithdrawable
    {
        void Withdraw(decimal sum);
    }
}
