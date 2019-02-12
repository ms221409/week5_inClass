using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform spawnPosition; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            Instantiate (bombPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
}
