using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public Door doors;
    //public KeyColor myColor;
    bool iCanOpen = false;
    bool locked = false;
    Animator key;
    private void Start()
    {
        key = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && iCanOpen && !locked)
        {
            key.SetBool("useKey", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            iCanOpen = true;
            Debug.Log("You Can Use Lock");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            iCanOpen = false;
            Debug.Log("You Can not Use Lock");
        }
    }
    public void UseKey()
    {
        Debug.Log("Otwieram");
        //foreach (Doors door in doors)
        //{
        doors.OpenClose();
        //}
    }

}
