using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class chatBoxCode : MonoBehaviour
{
    public GameObject chatIcon;
    public GameObject chatBox;
    public GameObject player;
    private TextMeshProUGUI TextPro;

    [TextArea]
    public string Words;

    private void Start()
    {
        chatIcon.gameObject.SetActive(false);
        chatBox.gameObject.SetActive(false);
        TextPro = this.gameObject.transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        TextPro.text = Words;
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






