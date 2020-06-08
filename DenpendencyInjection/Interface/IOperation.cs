using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenpendencyInjection.Interface
{
    public interface IOperation
    {
        Guid OperationId { get; }
    }



    public interface IOperationSingleton : IOperation { }
    public interface IOperationTransient : IOperation { }
    public interface IOperationScoped : IOperation { }
}
