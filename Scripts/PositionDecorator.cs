using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PositionDecorator : IPosition
{
    protected IPosition m_DecoratedPosition;

    public PositionDecorator(IPosition position)
    {
        m_DecoratedPosition = position;
    }

    public virtual int GetPoints()
    {
        return m_DecoratedPosition.GetPoints();
    }
}

/*
public class BasicPlayer : IPosition
{
    private int m_BasicAccuracy = 5;

    public int GetPoints()
    {
        return m_BasicAccuracy;
    }
}
*/

public class sOffense : PositionDecorator
{
    private int m_OffensePoints = 6;

    //constructor
    public sOffense(IPosition rifle) : base(rifle) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_OffensePoints;
    }
}

public class sDefense : PositionDecorator
{
    private int m_DefensePoints = 3;

    //constructor
    public sDefense(IPosition rifle) : base(rifle) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_DefensePoints;
    }
}

public class hTall : PositionDecorator
{
    private int m_TallPoints = 10;

    //constructor
    public hTall(IPosition position) : base(position) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_TallPoints;
    }
}

public class hShort : PositionDecorator
{
    private int m_ShortPoints = 2;

    //constructor
    public hShort(IPosition position) : base(position) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_ShortPoints;
    }
}

public class rFront : PositionDecorator
{
    private int m_FrontPoints = 5;

    //constructor
    public rFront(IPosition position) : base(position) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_FrontPoints;
    }
}

public class rBack : PositionDecorator
{
    private int m_BackPoints = 5;

    //constructor
    public rBack(IPosition position) : base(position) { }

    public override int GetPoints()
    {
        return base.GetPoints() + m_BackPoints;
    }
}

