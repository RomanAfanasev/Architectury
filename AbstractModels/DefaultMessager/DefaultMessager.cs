using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModels
{
    internal class DefaultMessager : MessagerAbstract
    {
        DtoAbstract dto;
        SenderAbstract sender;
        GetterAbstract<DtoAbstract> getter;
#pragma warning disable CS8618 //TODO Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public DefaultMessager(SenderAbstract sender, GetterAbstract<DtoAbstract> getter) : base(sender, getter)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.sender = sender;
            this.getter = getter;
        }

        public void Run()
        {
            dto = getter.Get();
            sender.Send(dto);
        }
    }

    public class DefaultSender: SenderAbstract
    {
        public DefaultSender(DtoAbstract dto): base(dto)
        {
        }

        public override void Send(DtoAbstract dto)
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultGetter<DtoAbstruct> : GetterAbstract<DtoAbstruct>
    {
        public override DtoAbstruct Get()
        {
            throw new NotImplementedException();
        }
    }
}
