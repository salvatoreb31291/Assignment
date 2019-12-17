using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   [SerializeField] int coinCount;

    SceneLoader sceneLoader;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CoinTaken()
    {
        coinCount--;

        if(coinCount <= 0)
        {
            sceneLoader.LoadNextScene();
        }
        if(coinCount >= 179)
        {
            FindObjectOfType<Health>().nextstage();
        }
    }

    public void CoinCount()
    {
        coinCount++;
    }

}
