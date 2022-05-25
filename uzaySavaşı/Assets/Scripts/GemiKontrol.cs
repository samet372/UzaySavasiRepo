using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{

    [SerializeField]
    GameObject kursunPrefab;

    [SerializeField]
    GameObject patlamaPrefab;

    const float hareketGucu = 5; //hareket gücü belirldik

    OyunKontrol oyunKontrol;

    
    void Start()
    {
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();
    }




    void Update()
    {
        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }
        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }
        transform.position = position;



        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunPozisyon = gameObject.transform.position;
            kursunPozisyon.y += 1;
            Instantiate(kursunPrefab, kursunPozisyon, Quaternion.identity);
        }
    }


     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GemiPatlama();
            oyunKontrol.OyunuBitir();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        } 

    }



}

