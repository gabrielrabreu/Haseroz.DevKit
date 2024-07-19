using MediatR;

namespace Haseroz.DevKit;

public interface ICommand<out TResponse> : IRequest<TResponse>;
