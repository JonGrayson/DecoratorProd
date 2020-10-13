using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPosition
{
    int GetPoints();
}

public class BasicPlayer : IPosition
{
    private int m_BasicAccuracy = 5;

    public int GetPoints()
    {
        return m_BasicAccuracy;
    }
}

public class OutsideHitter : IPosition
{
    public int GetPoints()
    {
        return 21;
    }
}

public class OppositeHitter : IPosition
{
    public int GetPoints()
    {
        return 18;
    }
}

public class Setter : IPosition
{
    public int GetPoints()
    {
        return 13;
    }
}
public class MiddleBlocker : IPosition
{
    public int GetPoints()
    {
        return 18;
    }
}

public class Libero : IPosition
{
    public int GetPoints()
    {
        return 10;
    }
}

public class Ace : IPosition
{
    public int GetPoints()
    {
        return 21;
    }
}

public class PinchServer : IPosition
{
    public int GetPoints()
    {
        return 10;
    }
}

public class Defender : IPosition
{
    public int GetPoints()
    {
        return 13;
    }
}
