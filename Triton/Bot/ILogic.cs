namespace Triton.Bot
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public interface ILogic
    {
        object Execute(string name, [Dynamic(new bool[] { false, true })] params object[] param);
        Task<bool> Logic(string type, [Dynamic(new bool[] { false, true })] params object[] param);
    }
}

