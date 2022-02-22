using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractModels.Interfaces
{
    public interface IMessegerBase<T>
    {
        void SetMessages(T[] dto);
        void GetMessages(T[] dto);
        void SendMessages(T[] dto);

        void LoggerStart();
        void LoggerStop();  
    }

    public interface IDtoMesseger<T> : IMessegerBase<T> where T : AbstractModels.DtoAbstract   //, расширяемо 
    {
               
    }
}
