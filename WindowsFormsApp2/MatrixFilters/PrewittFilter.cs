using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class PrewittFilter : BorderAllocation
    {
        public PrewittFilter()
        {
            createPrewittKernel();
        }
        protected void createPrewittKernel()
        {
            kernel = new float[,]
                {{-1, 0, 1 },
                 {-1, 0, 1 },
                 {-1, 0, 1 }};

        }
        protected override void changeFilterKernel(int ch)
        {
            if (ch == 1)
            {
                kernel = new float[,]
                       {{-1, 0, 1 },
                        {-1, 0, 1 },
                        {-1, 0, 1 }};
            }
            if (ch == 2)
            {
                kernel = new float[,]
                        {{-1, -1, -1 },
                         { 0,  0,  0 },
                         { 1,  1,  1 }};
            }
        }
    };
}
