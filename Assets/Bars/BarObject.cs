using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarObject
{
    int _MaxValue;
    int _CurrentValue;

    public int BarMaxValue
    {
        get
        {
            return _MaxValue;
        }
        set 
        {
            _MaxValue = value;
        }
    }

    public int getBarCurrentValue()
    {
            return _CurrentValue;
    }
    public int setBarCurrentValue(int value)
    {
        _CurrentValue = value;
            return _CurrentValue;
    }

    public BarObject (int max, int current)
    {
        _MaxValue = max;
        _CurrentValue = current;

    }

    public int BarDecrease (int ReducePoint)
    {
        if (_CurrentValue > 0)
        {
            _CurrentValue = _CurrentValue - ReducePoint;
        }
        return _CurrentValue;
    }

    public int BarIncrease (int IncreasePoint)
    {
        if (_CurrentValue < _MaxValue)
        {
            _CurrentValue = _CurrentValue + IncreasePoint;
        }
        if (_CurrentValue > _MaxValue)
        {
            _CurrentValue = _MaxValue;
        }
        return _CurrentValue;
    }
}
