using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area : MonoBehaviour
{
    public GameObject go;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            go.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            go.SetActive(false);
        }
    }
}
