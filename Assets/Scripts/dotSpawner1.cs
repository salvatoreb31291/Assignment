using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotSpawner1 : MonoBehaviour
{
    [SerializeField] GameObject MapCoins1;
    [SerializeField] Transform firstSpwanPoint;


    // Start is called before the first frame update
    void Start()
    {
        GameObject DotSpawner1 = Instantiate(MapCoins1, firstSpwanPoint.transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
