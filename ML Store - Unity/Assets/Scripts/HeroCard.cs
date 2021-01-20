using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroCard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI heroName;
    [SerializeField] Image heroImage;
    [SerializeField] TextMeshProUGUI cost;

    public void InitialiseCard(HeroData hero)
    {
        heroName.text = hero.GetHeroName();
        heroImage.sprite = hero.GetHeroImage();
        cost.text = hero.GetCost().ToString();
    }
}
