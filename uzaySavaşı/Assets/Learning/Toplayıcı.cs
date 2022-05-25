using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    [SerializeField]
    GameObject yildizPrefab;   //prefabı tanımladık

    List<GameObject> yildizlar = new List<GameObject>();    //yildizlar adında bir list oluşturduk


    /// <summary>
    /// Hedefteki yıldızı söyler
    /// </summary>
    public GameObject HedefYildiz   //hedef yıldıız belirlemek için bir property oluşturduk
    {

        get
        {
            if (yildizlar.Count>0)  //yildizlar listesinde toplanacak yildiz var ise 
            {
                return yildizlar[0];    //yıldızı gönder
            }

            else                    //yildiz yoksa boş
            {
                return null;
            }
        }

    }



   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))            //mausenin sağ tuşuna basınca çalış
        {
            Vector3 position = Input.mousePosition;             //mause poszisyonunu al
            position.z = -Camera.main.transform.position.z;     //pozisyıonu kameraya eşitle
            Vector3 oyunDunyasiPozisyon = Camera.main.ScreenToWorldPoint(position);     //pixelleri oyun dünyasına eşitle
            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPozisyon, Quaternion.identity));     //basınca yildiz var olsun
        }
    }


    /// <summary>
    /// parametre olarak gönderilen yildizi yok eder
    /// </summary>
    /// <param name="yokEdilecekYildiz"></param>
    public void YildizYokEdici(GameObject yokEdilecekYildiz)            //yildizi yok edecek metot
    {
        yildizlar.Remove(yokEdilecekYildiz);                //yok etmeden önce yildizi listeden çıkarmak gerekiyor
        Destroy(yokEdilecekYildiz);                         //yok et yıldız

    }












}
