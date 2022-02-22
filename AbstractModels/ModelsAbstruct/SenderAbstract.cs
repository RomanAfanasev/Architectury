using AbstractModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModels
{
    public abstract class SenderAbstract
    {
        private DtoAbstract[]? dtoArr = null;
        private DtoAbstract? dto = null;
        public SenderAbstract(DtoAbstract[] dtoArr)
        {
            this.dtoArr = dtoArr;
        }
        public SenderAbstract(DtoAbstract dto)
        {
            this.dto = dto;
        }

        public abstract void Send(DtoAbstract dto);

    }
}
