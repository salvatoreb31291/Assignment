using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    [SerializeField] int currentScore;
    [SerializeField] int pointsPerCoins;

    TextMeshProUGUI ScoreCount;

    void Awake()
    {
        int CoinsCount = FindObjectsOfType<Score>().Length;
        
        if(CoinsCount > 1)
        {
            
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreCount = FindObjectOfType<TextMeshProUGUI>();
        ScoreCount.text = currentScore.ToString();
    }


    public void AddPoints()
        {
        currentScore += pointsPerCoins;
        ScoreCount.text = currentScore.ToString();
        }
    
}
