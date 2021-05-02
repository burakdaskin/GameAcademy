using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tas_firlatma : MonoBehaviour
{
    public Rigidbody2D tas_rb2D; //tasin rigidbodysini baglamak icin tanimliyoruz
    bool egerClicked = false; //mouse tiklanip tiklanmadigini kontrol etmek icin
    public Rigidbody2D bn; //baglanti noktasi rigidbody
    public float en_buyuk_uzaklik;

    void Update()
    {
        if(egerClicked==true)
        {
            // tas_rb2D.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);//tas mouse'u takip ediyor
            Vector2 mouse_konumu = tas_rb2D.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mouse_konumu,bn.position)>en_buyuk_uzaklik) //2 konum arasi mesafe
            {
                tas_rb2D.position = bn.position + (mouse_konumu - bn.position).normalized * en_buyuk_uzaklik;
            }
            else
            {
                tas_rb2D.position = mouse_konumu;
            }
        }
    }
    void OnMouseDown() //mouse ile tasa tikladigimizda
    {
        egerClicked = true;
        tas_rb2D.isKinematic = true;
    }
    void OnMouseUp() //mouse biraktigimizda
    {
        egerClicked = false;
        tas_rb2D.isKinematic = false;
        Firlat();
    }
    void Firlat() //firlatma fonksiyonu
    {
        Destroy(GetComponent<SpringJoint2D>(), 0.05f); //baglanti noktasi ile arasindaki baglantiyi kesmek icin springjoint komponentini siliyoruz
    }
}
