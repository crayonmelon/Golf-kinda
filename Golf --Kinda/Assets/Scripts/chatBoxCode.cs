using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chatBoxCode : MonoBehaviour
{
    public GameObject chatIcon;
    public GameObject chatBox;
    public GameObject player;

    private void Start()
    {
        chatIcon.gameObject.SetActive(false);
        chatBox.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            chatIcon.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            chatIcon.gameObject.SetActive(false);
            chatBox.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            chatBox.gameObject.SetActive(true);
            print("E");

        }
    }
}






