using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{

    /// <summary>
    /// geminin maksimum hýz limiti
    /// </summary>
    int maksimumHiz;         // bunlar field lerimiz bunlarý tanýmladýk daha sonra deðiþken atýycaz 

    /// <summary>
    /// geminin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// maksimum hýz deðerini döner
    /// </summary>
    public int MaksimumHiz              // bu maksimum hýzý görmek için property sadece biz görelim diye deðil ayný zamanda sistem de bilsin diye
    {
        get
        {
            return maksimumHiz;
        }
    }

    /// <summary>
    /// geminin rengini döner
    /// </summary>
    public string Renk              // ayný þekilde renk property si
    {
        get
        {
            return renk;
        }
    }

    /// <summary>
    /// maksimum hýz ve rengi yazýn
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)         //field lara deðer atayabilmemizi saðlayan yer yani constructor, constructor lar class la ayný isimde olur oop konusudur nesne yaratmak içindir 
    {

        this.maksimumHiz = maksimumHiz;             // this field le property nin ismi ayný olunca sistemin neyin ne olduðunu anlamöasý için kullanýlýr this den sonra gelen property (=) den sonra gelen field 
        this.renk = renk;

    }

    public UzayGemisi(int maksimumHiz)              // renk belirlemek istemediðimiz bir uzay gemisi yapabilelim diye ikinci bir constructor yaptýk ve renk parameteresi eklemedik
    {
        this.maksimumHiz = maksimumHiz;
    }

    /// <summary>
    /// uzay gemisi hýzlandýrma super gücü
    /// </summary>
    public void Hizlandirici()    //gemiye boost vermek için metot oluþturduk
    {
        maksimumHiz += Random.Range(5, 20);     //geminin hýzýna 5,20 arasýnda bir deðer hýz olarak eklendi
        Debug.Log("hýzlandýrýcý" + maksimumHiz);
    }

    /// <summary>
    /// uzay gemisi yavaþlatma
    /// </summary>
    public void Yavaslatici()       //yavaþlatma metodu
    {
        maksimumHiz += Random.Range(-5, -20);       //geminin hýzýndan 5,20 arasý bir hýz düþecek
        Debug.Log("yavaþlatýcý" + maksimumHiz);

    }




}
