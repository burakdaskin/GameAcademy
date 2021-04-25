using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astro_hareket : MonoBehaviour
{
    public float hiz = 1f; //hiz degiskeni
    public int tas_sayisi; //toplanan taslarin sayisini gorebilmek icin kullaniyoruz
    public int buyuk_tas_sayisi; //buyuktaslarin sayisi
    public bool indi_mi = false; //platforma inip inmedigini kontrol etmek icin tanýmladik
    public Animator benim_animator; //animasyonu karaktere tanimlayacak
    float yatay;
    float dikey;
    public Text toplanan_tas_sayisi; //skor icin tanimlandi
    public Text toplanan_buyuk_tas_sayisi; //skor icin tanimlandi
    public GameObject oyunsonupaneli; //oyun sonu ekrani 
    public Text oyunsonu_tas_sayisi; //oyun sonu tas skoru
    public Text oyunsonu_buyuktas_sayisi; //oyun sonu buyuktas skoru
    public int saglik = 100; //saglik degiskeni ilk degeri 100
    public Text saglik_text; //saglik ui
    public static bool oyunumuz_basladi_mi = false;
    public GameObject Oyunbasipaneli;



    private void Start()
    {
        saglik_text.text = saglik.ToString(); //baslangicta sagligi gosterir
        oyunumuz_basladi_mi = false;
    }
    void FixedUpdate()
    {
        if (oyunumuz_basladi_mi==false)
        {
            return;
        }

        yatay = Input.GetAxis("Horizontal"); //yatayda hareket girdisi algilar, (sol-sag yon tuslari veya A-D) 
        transform.position += new Vector3(yatay*hiz, 0, 0); //sadece x ekseninde karaktere yatay*hiz kadar hareket verir

        //alttaki if yapisinda karakterin Transform komponentinde Scale'e erisip yonunu degistiriyoruz
        //scale'de yatay icin x'i, dikey icin y'yi eksi ile carpiyoruz
        
        dikey = Input.GetAxis("Vertical"); //dikey hareket (yukari-asagi yon tuslari veya W-S)
        transform.position += new Vector3(0, dikey * hiz, 0);

        YonDegistir(); //yon degistirme fonksiyonunu cagiriyoruz

        bool yuruyormuyuz = false; //yuruyup yurumedigini kontrol etmek icin atanan degisken
        if (yatay!=0) //sag veya sola tiklanmissa
        {
            yuruyormuyuz = true; 
        }
        if (yatay==0) //yatayda hareket etmiyorsa
        {
            yuruyormuyuz = false;
        }
        benim_animator.SetBool("yuruyormu", yuruyormuyuz); //animator ile kod baglantisini yapiyor
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
            saglik -= 20; //engelle temas edince 20 can gider
            saglik_text.text = saglik.ToString(); //sagligi ui'ye yazdirma

            if (saglik<=0) //saglik 0 olursa
            {
                Destroy(this.gameObject); //bagli oldugu nesneyi yokeder (burada Astro yokolur)
                oyunsonupaneli.SetActive(true);  //oyun sonunda ui daki paneli gorunur yapar
                
                oyunsonu_tas_sayisi.text = tas_sayisi.ToString(); //oyun sonundaki toplam tas sayisini gosteriyor
                oyunsonu_buyuktas_sayisi.text = buyuk_tas_sayisi.ToString(); //oyun sonundaki toplam buyuktas sayisini gosteriyor

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) //OnTriggerExit>>Temas kesildikten sonra tetikler
    {
        if (collision.tag == "Stone") //Tag'i Stone olan nesnelere temas ederse
        {
            tas_sayisi++; //tas sayisini bir arttir
            toplanan_tas_sayisi.text = tas_sayisi.ToString(); //skorumuzu ui'a yazdiriyoruz
            Debug.Log("Tas toplandi!"); //ekrana yaz
            Destroy(collision.gameObject); //toplanan nesneyi sil
        }
        if (collision.tag == "Buyuktas") //Tag'i Buyuktas olan nesnelere temas ederse
        {
            buyuk_tas_sayisi++; //buyuktas sayisini bir arttir
            toplanan_buyuk_tas_sayisi.text = buyuk_tas_sayisi.ToString(); //skorumuzu ui'a yazdiriyoruz
            Debug.Log("BuyukTas toplandi!"); //ekrana yaz
            Destroy(collision.gameObject); //toplanan nesneyi sil
        }

    }

    void YonDegistir()
    {
        if (yatay > 0) //karakter saga giderse yonu saga bakar
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (yatay < 0) //sola gidiyorsa sola doner
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (dikey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (dikey < 0)
        {
            transform.localScale = new Vector3(1, -1, 1);
        }
    }

    public void oyun_basladi() //oyun baslatma fonksiyonu
    {
        oyunumuz_basladi_mi = true;
        Oyunbasipaneli.SetActive(false);
    }
}