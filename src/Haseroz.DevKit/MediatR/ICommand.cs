using MediatR;

namespace Haseroz.DevKit.MediatR;

public interface ICommand<out TResponse> : IRequest<TResponse>;
