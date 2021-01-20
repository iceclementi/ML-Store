using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject heroCard;

    void Start()
    {
        PopulateInventory();
    }

    private void PopulateInventory()
    {
        var heroList = FindObjectOfType<HeroList>().GetList();
        foreach (HeroData hero in heroList)
        {
            var newHeroCard = Instantiate(heroCard, transform);
        }
    }
}
