using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{

    GeriSayimSayaci geriSayimSayaci;

    
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();      
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }



    void Update()
    {
        if(geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
