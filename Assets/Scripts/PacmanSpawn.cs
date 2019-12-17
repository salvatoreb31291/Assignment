using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanSpawn : MonoBehaviour
{
        [SerializeField] GameObject PacmanPrefab;
        [SerializeField] Transform PacmanSpwanPoint;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        GameObject Pacman = Instantiate(PacmanPrefab, PacmanSpwanPoint.transform.position,transform.rotation);
    }
}
