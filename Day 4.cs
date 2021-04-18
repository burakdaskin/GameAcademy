using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro_hareket : MonoBehaviour
{
    public float hiz = 1f; //hiz degiskeni
    public int tas_sayisi; //toplanan taslarin sayisini gorebilmek icin kullaniyoruz
    public bool indi_mi = false; //platforma inip inmedigini kontrol etmek icin tanýmladik

    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal"); //yatayda hareket girdisi algilar, (sol-sag yon tuslari veya A-D) 
        //Debug.Log(yatay);
        transform.position += new Vector3(yatay*hiz, 0, 0); //sadece x ekseninde karaktere yatay*hiz kadar hareket verir

        //alttaki if yapisinda karakterin Transform komponentinde Scale'e erisip yonunu degistiriyoruz
        //scale'de yatay icin x'i, dikey icin y'yi eksi ile carpiyoruz
        
        if (yatay>0) //karakter saga giderse yonu saga bakar
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (yatay<0) //sola gidiyorsa sola doner
        {
            transform.localScale = new Vector3(-1, 1,1);
        }

        float dikey = Input.GetAxis("Vertical"); //dikey hareket (yukari-asagi yon tuslari veya W-S)
        transform.position += new Vector3(0, dikey * hiz, 0);

        if (dikey>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (dikey<0)
        {
            transform.localScale = new Vector3(1, -1, 1);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision) //carpisma olaylari,OnTriggerEnter>>Temas ettigi anda tetikler
    {
        if (collision.gameObject.tag=="platform") //platform tag'ine sahip nesne ile temas ederse
        {
            if (indi_mi == false) //Astro'nun platforma inip inmedigini kontrol eder,
            {
                Debug.Log("Astronot gezegene indi");//indiginde ekrana bir kere yazar
            }
            indi_mi = true; //tekrar tekrar yazdirmamak icin kontrolu true yapar
        }

        if (collision.gameObject.tag=="engel") //engel tag'ine sahip nesne ile temas edrse
        {
            Debug.Log("Ahhhhh!!");//ekrana yazar
            Destroy(this.gameObject); //bagli oldugu nesneyi yokeder (burada Astro yokolur)
        }


    }

    private void OnTriggerExit2D(Collider2D collision) //OnTriggerExit>>Temas kesildikten sonra tetikler
    {
        if (collision.tag == "Stone") //Tag'i Stone olan nesnelere temas ederse
        {
            tas_sayisi++; //tas sayisini bir arttir
            Debug.Log("Tas toplandi!"); //ekrana yaz
            Destroy(collision.gameObject); //toplanan nesneyi sil
        }
    }
}