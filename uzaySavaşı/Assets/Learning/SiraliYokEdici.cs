using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GameObject uzayGemisi;

    List<GameObject> asteroidList; //listenin devam� start�n i�inde

    GameObject hedefAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        uzayGemisi = GameObject.FindGameObjectWithTag("Player"); //tag � player olarak belirledik
        asteroidList = new List<GameObject>(); // listenin devam�

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            GameObject asteroid = Instantiate(asteroidPrefab, position, Quaternion.identity);
            asteroidList.Add(asteroid); // her asteroidi listeye ekledik
        }

        if(Input.GetMouseButtonDown(1)) // yok etme metodunu �a��rdik
        {
            HedefiYokEt();
        }
    }

    GameObject EnYakinAsteroid()  //en yak�n asteroid belirlenecek
    {
        GameObject enYakinAsteroid;
        float enYakinMesafe;

        if(asteroidList.Count == 0)        //asteroid say�s� s�f�rsa bo� d�n
        {
            return null;
        }
        else
        {
            enYakinAsteroid = asteroidList[0];      //aster�id list teki birinci asterodi en yak�n kabul et sonra de�i�cek zaten
            enYakinMesafe = MesafeOlcer(enYakinAsteroid);       //mesafe �lcer metodunun en yak�n asteroidini en yak�n mesafe kabul et
        }

        foreach(GameObject asteroid in asteroidList)        //listedeki asteroidlerin hepsi
        {
            float mesafe = MesafeOlcer(asteroid);   //mesafe �l�erdeki asteroidi mesafe olarak kabul et
            if (mesafe < enYakinMesafe)         //o mesafe en ba�ta kabul edilen mesafeden k���kse
            {
                enYakinMesafe = mesafe;     //en yak�n mesafe, mesafe olsun
                enYakinAsteroid = asteroid;     //en yak�n asteroid de asteroid olsun
            }
        }

        return enYakinAsteroid;     //metod s�rekli d�ns�n






    }

    public void HedefiYokEt() // yok etme metodu
    {
        hedefAsteroid = EnYakinAsteroid();
        if (hedefAsteroid != null)
        {
            hedefAsteroid.GetComponent<YokEdici>().AsteroidYokEdici(1);
            asteroidList.Remove(hedefAsteroid);
        }

    }

    float MesafeOlcer(GameObject hedef)  //hedefi asterid olarak metodu �a��rd�p��um�zda parantezler aras�nda belirtcez
    {
        return Vector3.Distance(uzayGemisi.transform.position, hedef.transform.position);   //uzay gemisi ile hedefin mesafesini �l�
    }
}
