namespace Triton.Bot
{
    using System;
    using System.Threading.Tasks;

    public interface IRoutine : IRunnable, IAuthored, IBase, IConfigurable
    {
        object GetConfiguration(string name);
        Task<bool> Logic(string type, object context);
        void SetConfiguration(string name, params object[] param);
    }
}

