using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takipci_camera : MonoBehaviour
{
    public Transform takip_edilen; //kameranin takip edecegi nesne
    Vector3 mesafe; //kamera ile takip edilen nesne arasi uzaklik

    void Start()
    {
        mesafe = transform.position - takip_edilen.position;    
    }

    void LateUpdate()//kamera islemleri icin lateupdate kullaniyoruz
    {
        if (kure_hareket.fall==true)
        { return; }
        transform.position = takip_edilen.position + mesafe;
    }
}
