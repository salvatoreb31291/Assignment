using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    Level level;
    void OnTriggerEnter2D(Collider2D other)
    {
        
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if ( other.gameObject.CompareTag("Pacman"))
        {
            FindObjectOfType<Score>().AddPoints();
            level.CoinTaken();
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CoinCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
