using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData
{
    private string name;
    private int cost;

    public HeroData(string name, int cost)
    {
        this.name = name;
        this.cost = cost;
    }

    public string GetName()
    {
        return name;
    }

    public int GetCost()
    {
        return cost;
    }
}
