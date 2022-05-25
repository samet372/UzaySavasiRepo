using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{

    GeriSayimSayaci geriSayimSayaci;


    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
    }

    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
        }
    }





}
