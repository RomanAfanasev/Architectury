using AbstractModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModels
{
    public abstract class MessagerAbstract: IDtoMesseger
    {
        private GetterAbstract<DtoAbstract> getter;
        private SenderAbstract sender;
        public MessagerAbstract(SenderAbstract sender, GetterAbstract<DtoAbstract> getter)
        {
            this.getter = getter ?? throw new ArgumentNullException(nameof(sender));
            this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
        }


    }

    public abstract class ConsumerAbstruct
    {
        //protected CancellationTokenSource tokenSource = new CancellationTokenSource();
        internal abstract void StartConsume(IConnection? connection = null, Action<string>? receiveCallback = null);
        internal abstract void StopConsume(CancellationTokenSource? tokenSource = null);
        //{
        //    tokenSource.Cancel();
        //}
    }


}
