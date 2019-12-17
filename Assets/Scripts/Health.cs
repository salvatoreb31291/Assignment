using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public int CurrentHealth;
    [SerializeField] int DamagePoints;
    [SerializeField] GameObject Heart1,Heart2,Heart3;

    public void ReduceHealth()
        {
            
        CurrentHealth -= DamagePoints;

        if(CurrentHealth==3)
        {
            Heart1.gameObject.SetActive(true);
            Heart2.gameObject.SetActive(true);
            Heart3.gameObject.SetActive(true);
        }

        if(CurrentHealth==2)
        {
            Heart1.gameObject.SetActive(false);
        }

         if(CurrentHealth==1)
        {
            Destroy(Heart2);
        }

         if(CurrentHealth==0)
        {
            Destroy(Heart1);
            SceneManager.LoadScene("Lose");
        }

        }
    public void nextstage(){
        if(CurrentHealth>=1)
        {
            SceneManager.LoadScene("Win");
        }
    }    
    
}
