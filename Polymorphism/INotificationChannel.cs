using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Polymorphism
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}
