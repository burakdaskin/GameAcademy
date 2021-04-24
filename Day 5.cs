using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerde_miyiz : MonoBehaviour
{
    public LayerMask layer; //unity ortaminda aitlik katmanini secebilmek icin tanimladik
    public bool yerdemiyiz; //kontrol degiskeni
    public Rigidbody2D rb; //astronun rigidbodysini baglamak icin tanimladik

    void Update()
    {
        RaycastHit2D carpis = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, layer);
        //transform.position : isinin baslangic konumu
        //vector2.down : isinin gidecegi yonu belirliyor, asagidaki nesnelere degip degmedigini tespit icin down yapiyoruz
        //0.1f : vektorun buyuklugu
        //layer : Yer katmanini baglayacagiz
        if (carpis.collider != null) //isinin yere carpip carpmamasi
        {
            //isin bir yere carptiysa --> yerdeyiz
            yerdemiyiz = true;

        }
        else
        {
            //isin bir yere carpmiyor --> havadayiz
            yerdemiyiz = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && yerdemiyiz==true) //space'e bastiysak ve astro yerde ise
        {
            rb.velocity += new Vector2(0, 10f); //y ekseninde hizlanma yani ziplama hizi degeri
        }

    }   
}
