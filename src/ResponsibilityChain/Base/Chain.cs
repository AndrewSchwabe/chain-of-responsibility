using ResponsibilityChain.Interface;

namespace ResponsibilityChain.Base
{
    public class Chain<TInput, TOutput>
        where TInput : HandlerInputBase
        where TOutput : HandlerOutputBase
    {
        private IList<IHandler<TInput, TOutput>> _handlers { get; set; }

        public Chain()
        {
            _handlers = new List<IHandler<TInput, TOutput>>();
        }

        public void AddHandler(IHandler<TInput, TOutput> handler)
        {
            _handlers.Add(handler);
        }

        public async Task<bool> Execute(TInput input, TOutput output)
        {
            var success = false;
            if (_handlers.Any())
            {
                foreach (var handler in _handlers)
                {
                    success = await handler.Execute(input, output);
                }
            }

            return success;
        }
    }
}
