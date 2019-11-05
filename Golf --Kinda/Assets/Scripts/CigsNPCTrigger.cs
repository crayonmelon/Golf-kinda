using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CigsNPCTrigger : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI TextPro;
    Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && canvas.GetComponent<Collectables>().cigsCollected == true)
        {
            TextPro.text = "Oh Jeez, Oh Dear, Oh thanks so much";
            canvas.GetComponent<Collectables>().cigsCollected = false;
            anim.SetBool("hasCig", true);
        }
    }
}
