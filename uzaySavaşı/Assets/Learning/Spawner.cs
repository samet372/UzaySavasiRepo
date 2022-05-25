using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GeriSayimSayaci geriSayimSayaci;

    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if(geriSayimSayaci.Bitti)
        {
            //Spawn Game Object
            SpawnAsteroid();
            geriSayimSayaci.Calistir();
        
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
