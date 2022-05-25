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


        float yon = Random.Range(0f, 1.0f);         //aþaðýda asteroidlerin hareket yöneri var birisi saða birisi sola gidiyor burda yön deðiþkeni belirledik yön deðiþkenine 1 ve 0 arasýnda bir deðer verilecek bu deðer 0.5 ten küçükse if eðer büyükse else çalýþacak ve asteroidler random bir þekilde hareket etmiþ olacak.bunu yapmanýn daha farklý yollarý da var ama biz bunu seçtik
        if (yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse); //sola git
            rb2d.AddTorque(yon * 30.0f);  //giderken kendý eksenýn etrafýnda dön
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);     //saða git 
            rb2d.AddTorque(-yon * 30.0f);   //giderken kendi eksenin etrafýnda dön, -yon dedik çünkü saða giden asteroid saða sola giden sola doðru dönsün istedik
        }
        
        
        // bu aþamada asteroidler birbirine çarpýp yön deðiþtiriyodu biz bunu istmedik ve asteroidler birbirlerinin içinden geçsin istedik
        // bunu saðlamak için kod yazmadýk unity project settings kýsmýndan 2d physics kýsmýna geldik ve aþaðýda layer larýn etkileþim tikleri var asteroidlerin kesiþtiði 
        // tiki kaldýrdýk . tabi iþimiz layer olduðu için bunu yapmadan önce asteroid adýnda bir layer oluþturduk.
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kurþun")
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