using Livraria.Domain.Core.Commands;
using Livraria.Domain.Core.Events;
using System.Threading.Tasks;

namespace Livraria.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
