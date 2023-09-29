using Silkira.Abstractions;

namespace Silkira.Core;

public class Frame
{
    public Orientation MainAxis { get; init; }
    
    public uint Width { get; init; }

    public Frame(Orientation mainAxis, uint width)
    {
        MainAxis = mainAxis;
        Width = width;
    }

    public View View()
    {
        throw new NotImplementedException();
    }
}