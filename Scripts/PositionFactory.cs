using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPositionFactory
{
    IPosition Create(PositionRequirements requirements);
}

public abstract class AbstractPositionFactory
{
    public abstract IPosition Create();
}

public class OffenseFactory : IPositionFactory
{
    public IPosition Create(PositionRequirements requirements)
    {
        if(requirements.Row == true)
        {
            if (requirements.Height == true)
            {
                return new OutsideHitter();
            }
            else
            {
                return new Setter();
            }
        }
        else
        {
            if (requirements.Height == true)
            {
                return new Ace();
            }
            else
            {
                return new Defender();
            }
        }
    }
}

public class DefenseFactory :IPositionFactory
{
    public IPosition Create(PositionRequirements requirements)
    {
        if (requirements.Row == true)
        {
            if (requirements.Height == true)
            {
                return new OppositeHitter();
            }
            else
            {
                return new PinchServer();
            }
        }
        else
        {
            if (requirements.Height == true)
            {
                return new MiddleBlocker();
            }
            else
            {
                return new Libero();
            }
        }
    }
}

public class PositionFactory : AbstractPositionFactory
{
    private readonly IPositionFactory _factory;
    private readonly PositionRequirements _requirements;

    public PositionFactory(PositionRequirements requirements)
    {
        _factory = requirements.Style ? (IPositionFactory)new OffenseFactory() : new DefenseFactory();
        _requirements = requirements;
    }

    public override IPosition Create()
    {
        return _factory.Create(_requirements);
    }
}
