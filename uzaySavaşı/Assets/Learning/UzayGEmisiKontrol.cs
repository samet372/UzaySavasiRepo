using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGEmisiKontrol : MonoBehaviour
{

    const float hareketGucu = 5; //hareket g�c� belirldik

    bool topluyor = false;      //toplamaya ba�lad�ktan sonra tekrar gemiye t�klasak bile hdeften �a�mas�n diye bool yapt�k

    GameObject hedef;

    Rigidbody2D myRigidBody2D;

    Toplayici toplayici;  //Toplay�c� Scriptini �a��rd�k

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();        //atamalar�n� yapt�k
        toplayici = Camera.main.GetComponent<Toplayici>();  //, main cameran�n i�indeki toplay�c� scripti,atamas�n� yapt�k




    }

    void OnMouseDown()          //uzay gemisi colliderlerinin i�inde t�klad���m�zda gitvetopla metodunu �a��r dedik
    {
        if (!topluyor)          //y�ld�z toplam�yorken ge�erli olsun 
        {
            GitVeTopla();
        }


    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject == hedef)      //uzay gemisi y�ld�z�n collider leriyle temas edince o y�ld�z� yok ettt�ik
        {
            toplayici.YildizYokEdici(hedef);
            myRigidBody2D.velocity = Vector2.zero;
            GitVeTopla(); //ba�ka y�ld�z varsa tekrar hareket etmesi i�in metodu geri �a��rd�k

        }


    }





    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz;      //toplay�c� scriptinden hedefi belirleyip ona do�ru hareket etmeye ba�lad�

        if (hedef != null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            myRigidBody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse);

        }

    }


    // Update is called once per frame
    void Update()
    {

        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");

        //if (yatayInput != 0)
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime; 
        //}
        //if (dikeyInput != 0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}
        //transform.position = position;
    }
}
