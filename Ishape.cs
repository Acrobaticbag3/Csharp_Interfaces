using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Interfaces {
    public interface Ishape {
        protected int width { get; }
        protected int height { get; }

        void Ishape(int width, int height);

        public virtual void Circumferance() {
            
        }

        public virtual void Area() {
            
        }
    }
}