using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGEmisiKontrol : MonoBehaviour
{

    const float hareketGucu = 5; //hareket gücü belirldik

    bool topluyor = false;      //toplamaya baþladýktan sonra tekrar gemiye týklasak bile hdeften þaþmasýn diye bool yaptýk

    GameObject hedef;

    Rigidbody2D myRigidBody2D;

    Toplayici toplayici;  //Toplayýcý Scriptini çaðýrdýk

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();        //atamalarýný yaptýk
        toplayici = Camera.main.GetComponent<Toplayici>();  //, main cameranýn içindeki toplayýcý scripti,atamasýný yaptýk




    }

    void OnMouseDown()          //uzay gemisi colliderlerinin içinde týkladýðýmýzda gitvetopla metodunu çaðýr dedik
    {
        if (!topluyor)          //yýldýz toplamýyorken geçerli olsun 
        {
            GitVeTopla();
        }


    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject == hedef)      //uzay gemisi yýldýzýn collider leriyle temas edince o yýldýzý yok etttýik
        {
            toplayici.YildizYokEdici(hedef);
            myRigidBody2D.velocity = Vector2.zero;
            GitVeTopla(); //baþka yýldýz varsa tekrar hareket etmesi için metodu geri çaðýrdýk

        }


    }





    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz;      //toplayýcý scriptinden hedefi belirleyip ona doðru hareket etmeye baþladý

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
