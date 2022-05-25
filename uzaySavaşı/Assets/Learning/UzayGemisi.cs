using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{

    /// <summary>
    /// geminin maksimum h�z limiti
    /// </summary>
    int maksimumHiz;         // bunlar field lerimiz bunlar� tan�mlad�k daha sonra de�i�ken at�ycaz 

    /// <summary>
    /// geminin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// maksimum h�z de�erini d�ner
    /// </summary>
    public int MaksimumHiz              // bu maksimum h�z� g�rmek i�in property sadece biz g�relim diye de�il ayn� zamanda sistem de bilsin diye
    {
        get
        {
            return maksimumHiz;
        }
    }

    /// <summary>
    /// geminin rengini d�ner
    /// </summary>
    public string Renk              // ayn� �ekilde renk property si
    {
        get
        {
            return renk;
        }
    }

    /// <summary>
    /// maksimum h�z ve rengi yaz�n
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)         //field lara de�er atayabilmemizi sa�layan yer yani constructor, constructor lar class la ayn� isimde olur oop konusudur nesne yaratmak i�indir 
    {

        this.maksimumHiz = maksimumHiz;             // this field le property nin ismi ayn� olunca sistemin neyin ne oldu�unu anlam�as� i�in kullan�l�r this den sonra gelen property (=) den sonra gelen field 
        this.renk = renk;

    }

    public UzayGemisi(int maksimumHiz)              // renk belirlemek istemedi�imiz bir uzay gemisi yapabilelim diye ikinci bir constructor yapt�k ve renk parameteresi eklemedik
    {
        this.maksimumHiz = maksimumHiz;
    }

    /// <summary>
    /// uzay gemisi h�zland�rma super g�c�
    /// </summary>
    public void Hizlandirici()    //gemiye boost vermek i�in metot olu�turduk
    {
        maksimumHiz += Random.Range(5, 20);     //geminin h�z�na 5,20 aras�nda bir de�er h�z olarak eklendi
        Debug.Log("h�zland�r�c�" + maksimumHiz);
    }

    /// <summary>
    /// uzay gemisi yava�latma
    /// </summary>
    public void Yavaslatici()       //yava�latma metodu
    {
        maksimumHiz += Random.Range(-5, -20);       //geminin h�z�ndan 5,20 aras� bir h�z d��ecek
        Debug.Log("yava�lat�c�" + maksimumHiz);

    }




}
