using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData : MonoBehaviour
{
    private string heroName;
    private int cost;

    public HeroData(string heroName, int cost)
    {
        this.heroName = heroName;
        this.cost = cost;
    }

    public string GetHeroName()
    {
        return heroName;
    }

    public int GetCost()
    {
        return cost;
    }
}
