using MediatR;

namespace Haseroz.DevKit.MediatR;

public interface IQuery<out TResponse> : IRequest<TResponse>;
