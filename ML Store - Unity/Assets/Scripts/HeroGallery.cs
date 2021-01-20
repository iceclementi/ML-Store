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


    public Dictionary<string, Sprite> heroGallery; 

    private void Awake()
    {
        InitialiseSingleton();
    }

    private void InitialiseSingleton()
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

    public void InitialiseGallery()
    {
        heroGallery = new Dictionary<string, Sprite>();

        Util.AddToDictionary(
            heroGallery,
            new string[] {
                Hero.AKAI, Hero.ALDOUS, Hero.ALICE, Hero.ALPHA, Hero.ALUCARD, Hero.ANGELA, 
                Hero.ARGUS, Hero.ATLAS, Hero.AURORA, Hero.BADANG, Hero.BALMOND, Hero.BANE, 
                Hero.BARATS, Hero.BAXIA, Hero.BELERICK, Hero.BENEDETTA, Hero.BRODY, Hero.BRUNO, 
                Hero.CARMILLA, Hero.CECILION, Hero.CHANG_E, Hero.CHOU, Hero.CLAUDE, Hero.CLINT, 
                Hero.CYCLOPS, Hero.DIGGIE, Hero.DYRROTH, Hero.ESMERALDA, Hero.ESTES, Hero.EUDORA, 
                Hero.FANNY, Hero.FARAMIS, Hero.FRANCO, Hero.FREYA, Hero.GATOTKACA, Hero.GORD, 
                Hero.GRANGER, Hero.GROCK, Hero.GUINEVERE, Hero.GUSION, Hero.HANABI, Hero.HANZO, 
                Hero.HARITH, Hero.HARLEY, Hero.HAYABUSA, Hero.HELCURT, Hero.HILDA, Hero.HYLOS, 
                Hero.IRITHEL, Hero.JAWHEAD, Hero.JOHNSON, Hero.KADITA, Hero.KAGURA, Hero.KAJA, 
                Hero.KARINA, Hero.KARRIE, Hero.KHALEED, Hero.KHUFRA, Hero.KIMMY, Hero.LANCELOT, 
                Hero.LAPU_LAPU, Hero.LAYLA, Hero.LEOMORD, Hero.LESLEY, Hero.LING, Hero.LOLITA, 
                Hero.LUNOX, Hero.LUO_YI, Hero.LYLIA, Hero.MARTIS, Hero.MASHA, Hero.MATHILDA, 
                Hero.MINOTAUR, Hero.MINISITTHAR, Hero.MIYA, Hero.MOSKOV, Hero.NANA, Hero.NATALIA, 
                Hero.ODETTE, Hero.PHARSA, Hero.POPOL_AND_KUPA, Hero.RAFAELA, Hero.ROGER, Hero.RUBY, 
                Hero.SABER, Hero.SELENA, Hero.SILVANNA, Hero.SUN, Hero.TERIZLA, Hero.THAMUZ, 
                Hero.TIGREAL, Hero.URANUS, Hero.VALE, Hero.VALIR, Hero.VEXANA, Hero.WANWAN, 
                Hero.X_BORG, Hero.YI_SUN_SHIN, Hero.YU_ZHONG, Hero.ZHASK, Hero.ZILONG
            },
            new Sprite[] {
                Akai, Aldous, Alice, Alpha, Alucard, Angela, Argus, Atlas, Aurora, Badang, Balmond,
                Bane, Barats, Baxia, Belerick, Benedetta, Brody, Bruno, Carmilla, Cecilion, ChangE,
                Chou, Claude, Clint, Cyclops, Diggie, Dyrroth, Esmeralda, Estes, Eudora, Fanny,
                Faramis, Franco, Freya, Gatotkaca, Gord, Granger, Grock, Guinevere, Gusion, Hanabi,
                Hanzo, Harith, Harley, Hayabusa, Helcurt, Hilda, Hylos, Irithel, Jawhead, Johnson,
                Kadita, Kagura, Kaja, Karina, Karrie, Khaleed, Khufra, Kimmy, Lancelot, LapuLapu,
                Layla, Leomord, Lesley, Ling, Lolita, Lunox, LuoYi, Lylia, Martis, Masha, Mathilda,
                Minotaur, Minisitthar, Miya, Moskov, Nana, Natalia, Odette, Pharsa, PopolAndKupa,
                Rafaela, Roger, Ruby, Saber, Selena, Silvanna, Sun, Terizla, Thamuz, Tigreal, Uranus,
                Vale, Valir, Vexana, Wanwan, XBorg, YiSunShin, YuZhong, Zhask, Zilong
            }
        );
    }
}
