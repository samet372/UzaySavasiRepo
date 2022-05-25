using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GameObject uzayGemisi;

    List<GameObject> asteroidList; //listenin devamý startýn içinde

    GameObject hedefAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        uzayGemisi = GameObject.FindGameObjectWithTag("Player"); //tag ý player olarak belirledik
        asteroidList = new List<GameObject>(); // listenin devamý

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

        if(Input.GetMouseButtonDown(1)) // yok etme metodunu çaðýrdik
        {
            HedefiYokEt();
        }
    }

    GameObject EnYakinAsteroid()  //en yakýn asteroid belirlenecek
    {
        GameObject enYakinAsteroid;
        float enYakinMesafe;

        if(asteroidList.Count == 0)        //asteroid sayýsý sýfýrsa boþ dön
        {
            return null;
        }
        else
        {
            enYakinAsteroid = asteroidList[0];      //asterýid list teki birinci asterodi en yakýn kabul et sonra deðiþcek zaten
            enYakinMesafe = MesafeOlcer(enYakinAsteroid);       //mesafe ölcer metodunun en yakýn asteroidini en yakýn mesafe kabul et
        }

        foreach(GameObject asteroid in asteroidList)        //listedeki asteroidlerin hepsi
        {
            float mesafe = MesafeOlcer(asteroid);   //mesafe ölçerdeki asteroidi mesafe olarak kabul et
            if (mesafe < enYakinMesafe)         //o mesafe en baþta kabul edilen mesafeden küçükse
            {
                enYakinMesafe = mesafe;     //en yakýn mesafe, mesafe olsun
                enYakinAsteroid = asteroid;     //en yakýn asteroid de asteroid olsun
            }
        }

        return enYakinAsteroid;     //metod sürekli dönsün






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

    float MesafeOlcer(GameObject hedef)  //hedefi asterid olarak metodu çaðýrdýpðýumýzda parantezler arasýnda belirtcez
    {
        return Vector3.Distance(uzayGemisi.transform.position, hedef.transform.position);   //uzay gemisi ile hedefin mesafesini ölç
    }
}
