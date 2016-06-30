﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        public WTW t;
        public Person p;
        public Amount m;
        //instantiate all classes
        public Facade(string Name, string a, string b, float am)
        {
            t = new WTW(a,b);
            m = new Amount(am);
            p = new Person(Name);
        }
        //use all methods together in order to do one single thing
        public string exe()
        {
            return p._name + " has received " + m.returnProfit(t._l).ToString() + " on the period of "+ t.date[0] + " to " + t.date[1];
        }
    }
}
