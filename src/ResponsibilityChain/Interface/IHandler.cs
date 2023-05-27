using ResponsibilityChain.Base;

namespace ResponsibilityChain.Interface
{
    public interface IHandler<TInput, TOutput> 
        where TInput : HandlerInputBase
        where TOutput : HandlerOutputBase
    {
        Task<bool> Execute(TInput input, TOutput output);
    }
}
