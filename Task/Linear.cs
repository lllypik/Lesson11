using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    struct Linear
    {
        double factorB;
        double factorK;


        public Linear(double factorB, double factorK)
        {
            this.factorB = factorB;
            this.factorK = factorK;
        }

        public double Root()
        {
            return -factorB / factorK;
        }
        public string Note()
        {
            if (factorK == 0) return "Деление на 0! Не является ошибкой";
            else return "Замечания отсутствуют";
        }
    }
}