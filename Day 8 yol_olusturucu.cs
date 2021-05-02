using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yol_olusturucu : MonoBehaviour
{
    public GameObject son_yol;

    void Start()
    {
        for (int i = 0; i < 10; i++) //10 adet yol olustur
        {
            yol_olusturma();
        }
    }
    void yol_olusturma()
    { //instantiate = clone yapmaya yarar
        //        kopyalanacak nesne   , nereye kopyalayacak, nesnenin acisal konumu
        son_yol = Instantiate(son_yol, son_yol.transform.position + Vector3.forward, son_yol.transform.rotation);
    }
}
