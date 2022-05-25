using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;

    OyunKontrol oyunKontrol;



    private void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();    //asteroide rigidbody ekledik
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();


        float yon = Random.Range(0f, 1.0f);         //a�a��da asteroidlerin hareket y�neri var birisi sa�a birisi sola gidiyor burda y�n de�i�keni belirledik y�n de�i�kenine 1 ve 0 aras�nda bir de�er verilecek bu de�er 0.5 ten k���kse if e�er b�y�kse else �al��acak ve asteroidler random bir �ekilde hareket etmi� olacak.bunu yapman�n daha farkl� yollar� da var ama biz bunu se�tik
        if (yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse); //sola git
            rb2d.AddTorque(yon * 30.0f);  //giderken kend� eksen�n etraf�nda d�n
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);     //sa�a git 
            rb2d.AddTorque(-yon * 30.0f);   //giderken kendi eksenin etraf�nda d�n, -yon dedik ��nk� sa�a giden asteroid sa�a sola giden sola do�ru d�ns�n istedik
        }
        
        
        // bu a�amada asteroidler birbirine �arp�p y�n de�i�tiriyodu biz bunu istmedik ve asteroidler birbirlerinin i�inden ge�sin istedik
        // bunu sa�lamak i�in kod yazmad�k unity project settings k�sm�ndan 2d physics k�sm�na geldik ve a�a��da layer lar�n etkile�im tikleri var asteroidlerin kesi�ti�i 
        // tiki kald�rd�k . tabi i�imiz layer oldu�u i�in bunu yapmadan �nce asteroid ad�nda bir layer olu�turduk.
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kur�un")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AsteroidPatlama();
            oyunKontrol.AsteroidYokOldu(gameObject);
            AsteroidYokEt();


        }
    }

    public void AsteroidYokEt()
    {

        Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);



    }





}