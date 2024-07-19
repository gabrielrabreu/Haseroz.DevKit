using MediatR;

namespace Haseroz.DevKit;

public interface IQuery<out TResponse> : IRequest<TResponse>;
