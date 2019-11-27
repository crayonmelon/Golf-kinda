using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    private AudioSource aS;
    public float speed = 10;
    private Rigidbody rb;
    public float maxSpeed = 50f;
    public float maxSongPitch = 1.5f;
    public float minSongPitch = 0.5f;

    public Transform Target;
    public Scrollbar VolScrol;

    float musicPitch;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        aS = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        aS.volume = VolScrol.value;
        print(VolScrol.value);

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 cam = Target.forward * -1;
            Vector3 camFwd = new Vector3(cam.x, 0, cam.z);
            rb.AddForce(camFwd * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 cam = Target.forward;
            Vector3 camFwd = new Vector3(cam.x, 0, cam.z);
            rb.AddForce(camFwd * speed);
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        musicPitch = Mathf.Clamp(rb.velocity.magnitude / 20, 0.5f, 3f);

        print(musicPitch);
        if(musicPitch > 1)
        {
            aS.pitch = maxSongPitch;
        }
        else
        {
            aS.pitch = Mathf.Clamp(rb.velocity.magnitude / 20, minSongPitch, maxSongPitch);
        }        
    }
}
