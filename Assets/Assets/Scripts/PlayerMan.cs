using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMan : MonoBehaviour
{
    public GameObject doorbutton;
    public GameObject PlatForm;
    public GameObject up;

    public GameObject keyicon;
    public GameObject gearicon;
    public GameObject ammoicon;
    bool key = false, gear = false, ammo = false, plat = false;

    void dooropen()
    {
        Debug.Log("dooring");
        if(key)
        {
            doorbutton.transform.position = Vector3.Lerp(doorbutton.transform.position, new Vector3(6.369f, 5, 7.16f), 1f);
        } 
        
    }

    void platform()
    {
        if (gear)
        {
            PlatForm.transform.position = Vector3.Lerp(doorbutton.transform.position, up.transform.position, 1f);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            key = true;
            Destroy(other.gameObject);
            keyicon.SetActive(true);
        }
        if (other.gameObject.CompareTag("Ammo"))
        {
            ammo = true;
            Destroy(other.gameObject);
            ammoicon.SetActive(true);
        }
        if (other.gameObject.CompareTag("Gear"))
        {
            gear = true;
            Destroy(other.gameObject);
            gearicon.SetActive(true);
        }

        if (other.gameObject.CompareTag("Button"))
        {
            Debug.Log("door");
            dooropen();
        }

        if (other.gameObject.CompareTag("Platform"))
        {
            platform();
        }
    }
}
