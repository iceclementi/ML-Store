using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroGallery : MonoBehaviour
{
    [SerializeField]
    Sprite Akai, Aldous, Alice, Alpha, Alucard, Angela, Argus, Atlas, 
    Aurora, Badang, Balmond, Bane, Barats, Baxia, Belerick, Benedetta, Brody, Bruno, 
    Carmilla, Cecilion, ChangE, Chou, Claude, Clint, Cyclops, Diggie, Dyrroth, Esmeralda,
    Estes, Eudora, Fanny, Faramis, Franco, Freya, Gatotkaca, Gord, Granger, Grock, 
    Guinevere, Gusion, Hanabi, Hanzo, Harith, Harley, Hayabusa, Helcurt, Hilda, Hylos, 
    Irithel, Jawhead, Johnson, Kadita, Kagura, Kaja, Karina, Karrie, Khaleed, Khufra, 
    Kimmy, Lancelot, LapuLapu, Layla, Leomord, Lesley, Ling, Lolita, Lunox, LuoYi, 
    Lylia, Martis, Masha, Mathilda, Minotaur, Minisitthar, Miya, Moskov, Nana, Natalia, 
    Odette, Pharsa, PopolAndKupa, Rafaela, Roger, Ruby, Saber, Selena, Silvanna, Sun, 
    Terizla, Thamuz, Tigreal, Uranus, Vale, Valir, Vexana, Wanwan, XBorg, YiSunShin, 
    YuZhong, Zhask, Zilong;

    private void Awake()
    {
        var numberOfInstances = FindObjectsOfType<HeroGallery>();

        if (numberOfInstances.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
