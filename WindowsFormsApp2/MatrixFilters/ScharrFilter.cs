using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ScharrFilter : BorderAllocation
    {
        public ScharrFilter()
        {
            createScharrKernel();
        }
        protected void createScharrKernel()
        {
            kernel = new float[,]
                {{ -3, 0, 3 },
                 {-10, 0, 10 },
                 { -3, 0, 3 }};

        }
        protected override void changeFilterKernel(int ch)
        {
            if (ch == 1)
            {
                kernel = new float[,]
                       {{ -3, 0, 3 },
                        {-10, 0, 10 },
                        { -3, 0, 3 }};
            }
            if (ch == 2)
            {
                kernel = new float[,]
                        {{-3, -10, -3 },
                         { 0,   0,  0 },
                         { 3,  10,  3 }};
            }
        }
    };
}
