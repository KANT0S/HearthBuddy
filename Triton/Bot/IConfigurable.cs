namespace Triton.Bot
{
    using System.Windows.Controls;
    using Triton.Common;

    public interface IConfigurable
    {
        UserControl Control { get; }

        JsonSettings Settings { get; }
    }
}

