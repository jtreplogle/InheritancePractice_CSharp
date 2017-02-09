using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasicPractice1
{
    class Software
    {
        public Software()
        {
            m_x = 100;
        }
        public Software(int y)
        {
            m_x = y;
        }
        protected int m_x;
    }
}
