using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    

    void Start()
    {


        UzayGemisi gemi1 = new UzayGemisi(Random.Range(50, 90));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(50, 90), "kýrmýzý");

        gemi1.Hizlandirici();
        gemi2.Hizlandirici();

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("kazanan gemi1 :" + gemi1.MaksimumHiz);

        }

        else if (gemi2.MaksimumHiz > gemi1.MaksimumHiz)
        {
            Debug.Log("kazanan gemi2 :" + gemi2.MaksimumHiz);

        }

        else
        {
            Debug.Log("berabere :" + gemi2.MaksimumHiz);

        }













        //int saldiranDusman = 10;                //düþman sayýsý belirledik
        //bool saldiriDevam = false;               //saldýrý devam ediyormu diye kontrol ettik

        //while(saldiriDevam)                              saldýrý devam true olduðu sürece çalýþ
        //{
        //    saldiranDusman--;                            saldýran süþmaný her seferde 1 azalt
        //    if (saldiranDusman < 3)                      saldýran düþman 3 ten küçük olunca 
        //    {
        //        saldiriDevam = false;                    küçük olunca dur
        //    }
        //    Debug.Log("saldýrý altýndayýz.düþman sayýsý: " + saldiranDusman);

        //}

                            //do ile while arasýndaki farký anlamak içþn burdaki kodlarý yazdýk do içindeki satýrý en az bir kere çalýþtýrýr burda saldýrý devam true olunca çalýþmasý gerekn kod false olunca do içinde olduðu için false olmasýna raðmen 1 kere çalýþýp durdu
        //do
        //{
        //    saldiranDusman--;                       //do içinde en az bir kere çalýþacak
        //    if (saldiranDusman < 3) 
        //    {
        //        saldiriDevam = false; 
        //    }
        //    Debug.Log("saldýrý altýndayýz.düþman sayýsý: " + saldiranDusman);

        //} while (saldiriDevam);         //eðer koþul doðruysa çalýþmaya devam edecek









    }






    void Update()
    {
        
    }
}
