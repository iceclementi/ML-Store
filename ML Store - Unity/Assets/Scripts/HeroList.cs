using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroList : MonoBehaviour
{
    private HeroGallery heroGallery;

    private List<HeroData> heroes = new List<HeroData>();

    private void Awake()
    {
        InitialiseSingleton();
    }

    private void Start()
    {
        heroGallery = GetComponent<HeroGallery>();
        heroGallery.InitialiseGallery();
        InitialiseHeroes();
    }

    public List<HeroData> GetList()
    {
        return heroes;
    }

    private void InitialiseSingleton()
    {
        var numberOfInstances = FindObjectsOfType<HeroList>();

        if (numberOfInstances.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void InitialiseHeroes()
    {
        Util.AddToList(heroes,
            CreateHero(Hero.AKAI, 0), CreateHero(Hero.ALDOUS, 599), CreateHero(Hero.ALICE, 399),
            CreateHero(Hero.ALPHA, 599), CreateHero(Hero.ALUCARD, 0), CreateHero(Hero.ANGELA, 499), 
            CreateHero(Hero.ARGUS, 599), CreateHero(Hero.ATLAS, 599), CreateHero(Hero.AURORA, 499), 
            CreateHero(Hero.BADANG, 599), CreateHero(Hero.BALMOND, 299), CreateHero(Hero.BANE, 299), 
            CreateHero(Hero.BARATS, 599), CreateHero(Hero.BAXIA, 599), CreateHero(Hero.BELERICK, 599), 
            CreateHero(Hero.BENEDETTA, 599), CreateHero(Hero.BRODY, 599), CreateHero(Hero.BRUNO, 399), 
            CreateHero(Hero.CARMILLA, 599), CreateHero(Hero.CECILION, 599), CreateHero(Hero.CHANG_E, 599), 
            CreateHero(Hero.CHOU, 499), CreateHero(Hero.CLAUDE, 599), CreateHero(Hero.CLINT, 0),
            CreateHero(Hero.CYCLOPS, 399), CreateHero(Hero.DIGGIE, 499), CreateHero(Hero.DYRROTH, 599), 
            CreateHero(Hero.ESMERALDA, 599), CreateHero(Hero.ESTES, 499), CreateHero(Hero.EUDORA, 299), 
            CreateHero(Hero.FANNY, 499), CreateHero(Hero.FARAMIS, 599), CreateHero(Hero.FRANCO, 0), 
            CreateHero(Hero.FREYA, 599), CreateHero(Hero.GATOTKACA, 599), CreateHero(Hero.GORD, 0), 
            CreateHero(Hero.GRANGER, 599), CreateHero(Hero.GROCK, 599), CreateHero(Hero.GUINEVERE, 599), 
            CreateHero(Hero.GUSION, 599), CreateHero(Hero.HANABI, 599), CreateHero(Hero.HANZO, 599),
            CreateHero(Hero.HARITH, 599), CreateHero(Hero.HARLEY, 599), CreateHero(Hero.HAYABUSA, 599), 
            CreateHero(Hero.HELCURT, 599), CreateHero(Hero.HILDA, 499), CreateHero(Hero.HYLOS, 599), 
            CreateHero(Hero.IRITHEL, 599), CreateHero(Hero.JAWHEAD, 599), CreateHero(Hero.JOHNSON, 599), 
            CreateHero(Hero.KADITA, 599), CreateHero(Hero.KAGURA, 599), CreateHero(Hero.KAJA, 599), 
            CreateHero(Hero.KARINA, 599), CreateHero(Hero.KARRIE, 499), CreateHero(Hero.KHALEED, 599), 
            CreateHero(Hero.KHUFRA, 599), CreateHero(Hero.KIMMY, 599), CreateHero(Hero.LANCELOT, 599), 
            CreateHero(Hero.LAPU_LAPU, 599), CreateHero(Hero.LAYLA, 299), CreateHero(Hero.LEOMORD, 599),
            CreateHero(Hero.LESLEY, 599), CreateHero(Hero.LING, 599), CreateHero(Hero.LOLITA, 599), 
            CreateHero(Hero.LUNOX, 599), CreateHero(Hero.LUO_YI, 599), CreateHero(Hero.LYLIA, 599), 
            CreateHero(Hero.MARTIS, 599), CreateHero(Hero.MASHA, 599), CreateHero(Hero.MATHILDA, 599), 
            CreateHero(Hero.MINOTAUR, 399), CreateHero(Hero.MINISITTHAR, 599), CreateHero(Hero.MIYA, 399), 
            CreateHero(Hero.MOSKOV, 599), CreateHero(Hero.NANA, 299), CreateHero(Hero.NATALIA, 599), 
            CreateHero(Hero.ODETTE, 0), CreateHero(Hero.PHARSA, 599), CreateHero(Hero.POPOL_AND_KUPA, 599), 
            CreateHero(Hero.RAFAELA, 299), CreateHero(Hero.ROGER, 499), CreateHero(Hero.RUBY, 599), 
            CreateHero(Hero.SABER, 299), CreateHero(Hero.SELENA, 599), CreateHero(Hero.SILVANNA, 599), 
            CreateHero(Hero.SUN, 599), CreateHero(Hero.TERIZLA, 599), CreateHero(Hero.THAMUZ, 599), 
            CreateHero(Hero.TIGREAL, 299), CreateHero(Hero.URANUS, 599), CreateHero(Hero.VALE, 599), 
            CreateHero(Hero.VALIR, 599), CreateHero(Hero.VEXANA, 599), CreateHero(Hero.WANWAN, 599), 
            CreateHero(Hero.X_BORG, 599), CreateHero(Hero.YI_SUN_SHIN, 599), CreateHero(Hero.YU_ZHONG, 599), 
            CreateHero(Hero.ZHASK, 599), CreateHero(Hero.ZILONG, 399)
        );
    }

    private HeroData CreateHero(string heroName, int cost)
    {
        return new HeroData(heroName, heroGallery.heroGallery[heroName], cost);
    }
}
