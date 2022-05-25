using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroidList = new List<GameObject>(); //asteroidleri list olarak tanımladık 

    //GameObject[] asteroidler = new GameObject[4]; //bu bir array,array çoklu değşken tanımlamadır,burda asteroidler adında 4 elemanlı bir değişken tanımladık,array de kaç eleman olması gerektiğini yazmak zorundayız



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            for(int i = 0; i < 20; i++) //for dongüsü kullnadık burda dongu 20 olana kadar asteroid ekleyecek
            {
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));  //tanımladığımız list i böyle kullanıyoruz,asteroidList.Add = lsiteye ekle anlamında geriis zaten bizim asteroid kodu
            }

            
            //asteroidler[1] = Instantiate(asteroidPrefab, position, Quaternion.identity); //array için kullandık ,sıfırdan başlıyo biliyosun zaten meseleyi 0.array asteroid uretti 1.array asteroid üretti
            //asteroidler[2] = Instantiate(asteroidPrefab, position, Quaternion.identity); //şeklinde 4 arraye de atama yaptık ve mouse tıklanınca 4 tane asteroid yarattık
            //asteroidler[3] = Instantiate(asteroidPrefab, position, Quaternion.identity);
        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("sol click.");
        //}

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(asteroidList.Count);      //listedeki elemanları kontrol etmek içn yaptık

            foreach(GameObject asteroid in asteroidList)    //foreach normal for gibi ama değişken belirlemeye vs gerek yok daha kısa şekilde elemanların hepsnini yok etmemizi sağladı
            {
                Destroy(asteroid);
            }

            asteroidList.Clear();       //dongü bittikten sonra listedeki elemanları temizledik yoksa ekranda olmamasına rağman eski asteroidlerin üzerine koyarak saymaya devam ediyor bu da bir müddet sonra pc yi zorlar mesela ekranda 20 asteroid var ama listede 120

            //for (int i = 0; i < asteroidList.Count; i++)    //listenin tamamını kapsa annlamında bir döngü
            //{
            //    Destroy(asteroidList[i]);   //listeyi yok et
            //}
        }

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("orta click");
        //}
    }
}
