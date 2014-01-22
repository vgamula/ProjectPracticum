using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class AbstractBridge
    {
        protected AbstractExecutor _executor;

        public AbstractExecutor Executor 
        { 
            get 
            {
                return this._executor;
            }
            set
            {
                this._executor = value;
            }
        }

        public virtual void Execute()
        {
            if (this._executor != null)
                _executor.DoOperation();
        }
    }
}
