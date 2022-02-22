using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModels
{
    public abstract class GetterAbstract<T>
    {
        private DtoAbstract[]? dtoArr = null;
        private DtoAbstract? dto = null;

        public abstract T Get();

    }
}
