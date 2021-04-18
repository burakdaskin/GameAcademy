using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro_hareket : MonoBehaviour
{
    /*Vector3 noktaA = new Vector3(-4, 0, 0);
    Vector3 noktaB = new Vector3(4, 0, 0);
    float hiz = 1f;
    float t;*/

    public float itki = 5f;
    Rigidbody2D rb;

    void Start() //baslangicta calisir
    {

    }


    void Update() //start'tan sonra calisir
    {

        rb.velocity = transform.right * itki * Time.deltaTime; //hiz ekleme ile sabit bir hizda hareket ettirir


        //rb.AddForce(transform.right * itki); //guc ekleyerek hareket



        //transform.Translate(3 * Time.deltaTime, 0, 0);

        /* 
        volta attirma 

        t += Time.deltaTime * hiz;
        transform.position = Vector3.Lerp(noktaA, noktaB, t); //Lerp: iki nokta arasinda hareket ettirir

        if (t>=1) //t, 1'i gecince karakter yon degistirir, 0'a esitlenince tekrar yon degistirir
        {
            var b = noktaB;
            var a = noktaA;
            noktaA = b; 
            noktaB = a;
            t = 0;
        }
        */


        /*
        baslangic noktasindan hedef'e hareket ettirme
        Vector3 hedef = new Vector3(8, 0, 0);
        float hiz = 10f;
        transform.position = Vector3.MoveTowards(transform.position, hedef, Time.deltaTime * hiz);
        */
    }

    /*
        Awake: Oyun baslamadan 1 kez calisir.
        Start: Oyun baslayinca 1 kez calisir.
        Update: Her frame calisir.
        FixedUpdate: Update oranla daha hizli
        LatedUpdate: Update oranla daha yavas

    void FixedUpdate()
    {
            
    }

    void LateUpdate() //daha cok kamera fonksiyonlarinda kullanilir
    {
           
    }

    void Awake() //oyun baslangicinda hizli bir sekilde baslatilacak kodlar buraya yazilir (start'tan once calisir)
    {
        
    }
    */

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}