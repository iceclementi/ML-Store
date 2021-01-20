using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData
{
    private string name;
    private Sprite image;
    private int cost;

    public HeroData(string name, Sprite image, int cost)
    {
        this.name = name;
        this.image = image;
        this.cost = cost;
    }

    public string GetHeroName()
    {
        return name;
    }

    public Sprite GetHeroImage()
    {
        return image;
    }

    public int GetCost()
    {
        return cost;
    }
}
