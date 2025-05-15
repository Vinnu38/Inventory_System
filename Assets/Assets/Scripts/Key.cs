using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject textkey;
    [SerializeField] Transform player;

    private void Update()
    {
        textkey.transform.LookAt(player);
    }

}
