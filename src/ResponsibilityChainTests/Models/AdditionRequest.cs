using ResponsibilityChain.Base;

namespace ResponsibilityChainTests.Models
{
    public class AdditionRequest : HandlerInputBase
    {
        public int InputOne { get; set; }
        public int InputTwo { get; set; }
    }
}