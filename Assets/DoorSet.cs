using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSet : MonoBehaviour
{
    float y1;
    public float y2;
    private void Start()
    {
        y1 = transform.eulerAngles.y;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") 
        {
            other.GetComponent<Animator>().SetTrigger("pick");
        this.transform.eulerAngles=new Vector3(0,y2,0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") 
        {
            this.transform.eulerAngles = new Vector3(0, y1, 0);
        }
    }
}
