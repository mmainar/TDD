﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);

        Expression Plus(Expression addend);

        Expression Times(int multiplier);
    }
}
