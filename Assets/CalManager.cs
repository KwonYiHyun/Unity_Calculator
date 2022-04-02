using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Stat {
    Plus,
    Minus,
    Times,
    Division,
    Result
}

public class CalManager : MonoBehaviour
{
    public Text text;

    public bool isstats;
    public Stat stat;

    public double num = 0;
    public double sp = 0;

    void Start()
    {
        isstats = false;
    }

    void setText()
    {
        text.text = num + "";
    }

    public void _1()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 1;
        }
        else
        {
            num *= 10;
            num += 1;
            setText();
        }
    }

    public void _2()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 2;
        }
        else
        {
            num *= 10;
            num += 2;
            setText();
        }
    }

    public void _3()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 3;
        }
        else
        {
            num *= 10;
            num += 3;
            setText();
        }
    }

    public void _4()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 4;
        }
        else
        {
            num *= 10;
            num += 4;
            setText();
        }
    }

    public void _5()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 5;
        }
        else
        {
            num *= 10;
            num += 5;
            setText();
        }
    }

    public void _6()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 6;
        }
        else
        {
            num *= 10;
            num += 6;
            setText();
        }
    }

    public void _7()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 7;
        }
        else
        {
            num *= 10;
            num += 7;
            setText();
        }
    }

    public void _8()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 8;
        }
        else
        {
            num *= 10;
            num += 8;
            setText();
        }
    }

    public void _9()
    {
        if (isstats)
        {
            sp *= 10;
            sp += 9;
        }
        else
        {
            num *= 10;
            num += 9;
            setText();
        }
    }

    public void _0()
    {
        if (isstats)
        {
            sp *= 10;
        }
        else
        {
            num *= 10;
            num += 0;
            setText();
        }
    }

    public void _Plus()
    {
        _Result();
        stat = Stat.Plus;
        isstats = true;
    }

    public void _Minus()
    {
        _Result();
        stat = Stat.Minus;
        isstats = true;
    }

    public void _Times()
    {
        _Result();
        stat = Stat.Times;
        isstats = true;
    }

    public void _Division()
    {
        _Result();
        stat = Stat.Division;
        isstats = true;
    }

    public void _Result()
    {
        
        isstats = false;

        switch (stat)
        {
            case Stat.Plus:
                num = num + sp;
                setText();
                break;
            case Stat.Minus:
                num = num - sp;
                setText();
                break;
            case Stat.Division:
                num = num / sp;
                setText();
                break;
            case Stat.Times:
                num = num * sp;
                setText();
                break;
        }
        sp = 0;
        stat = Stat.Result;
    }
}
