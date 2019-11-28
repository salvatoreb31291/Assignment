using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotSpawner2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject MapCoins2;
    [SerializeField] Transform firstSpwanPoint;

    void Start()
    {
        GameObject DotSpawner2 = Instantiate(MapCoins2, firstSpwanPoint.transform.position,transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
