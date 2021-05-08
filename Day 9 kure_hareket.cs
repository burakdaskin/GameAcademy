using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kure_hareket : MonoBehaviour
{
    Vector3 yon;
    public float hiz;
    public yol_olusturucu yol_olusturuyoruz; //bu scripti yol olustur scripti ile bagliyoruz
    public static bool fall;

    void Start()
    {
        yon = Vector3.forward; //ileri hareket (0,0,1)
        fall = false;
    }

    void Update()
    {
        if (fall==true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0)) //mouse'un sol tusuna basildiysa
        {//x = left, z = forward
            if (yon.x==0) //x e gitmiyorum z yonunde gidiyorum
            {
                yon = Vector3.left; 
            }
            else //yani x yonunde gidiyorum
            {
                yon = Vector3.forward; //z ye dondur
            }
        }
        if (transform.position.y <-0.5f)
        {
            Destroy(this.gameObject); //topu siler
            fall = true;
        }
    }

    void FixedUpdate()
    {
        if (fall == true)
        {
            return;
        }
        Vector3 kure_move = yon * Time.deltaTime * hiz; //kure hareket vektoru
        transform.position += kure_move; //
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag== "yolum")
        {
            StartCoroutine(Yoket(collision.gameObject));//enumerator fonksiyonunu calistirir
            yol_olusturuyoruz.yol_olusturma();
        }
    }

    IEnumerator Yoket(GameObject yok_edilecek_yol) //geride kalan yollari yoketme fonksiyonu
    {
        yield return new WaitForSeconds(0.5f); //0.5 sn bekle (ienumerator icin geri donme)
        yok_edilecek_yol.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(1.2f);
        Destroy(yok_edilecek_yol);
    }
}
