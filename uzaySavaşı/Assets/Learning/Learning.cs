using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    

    void Start()
    {


        UzayGemisi gemi1 = new UzayGemisi(Random.Range(50, 90));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(50, 90), "k�rm�z�");

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













        //int saldiranDusman = 10;                //d��man say�s� belirledik
        //bool saldiriDevam = false;               //sald�r� devam ediyormu diye kontrol ettik

        //while(saldiriDevam)                              sald�r� devam true oldu�u s�rece �al��
        //{
        //    saldiranDusman--;                            sald�ran s��man� her seferde 1 azalt
        //    if (saldiranDusman < 3)                      sald�ran d��man 3 ten k���k olunca 
        //    {
        //        saldiriDevam = false;                    k���k olunca dur
        //    }
        //    Debug.Log("sald�r� alt�nday�z.d��man say�s�: " + saldiranDusman);

        //}

                            //do ile while aras�ndaki fark� anlamak i��n burdaki kodlar� yazd�k do i�indeki sat�r� en az bir kere �al��t�r�r burda sald�r� devam true olunca �al��mas� gerekn kod false olunca do i�inde oldu�u i�in false olmas�na ra�men 1 kere �al���p durdu
        //do
        //{
        //    saldiranDusman--;                       //do i�inde en az bir kere �al��acak
        //    if (saldiranDusman < 3) 
        //    {
        //        saldiriDevam = false; 
        //    }
        //    Debug.Log("sald�r� alt�nday�z.d��man say�s�: " + saldiranDusman);

        //} while (saldiriDevam);         //e�er ko�ul do�ruysa �al��maya devam edecek









    }






    void Update()
    {
        
    }
}
