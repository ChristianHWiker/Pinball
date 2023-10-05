using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    private float force;
    public float maxForce = 10000f;
    public Slider launchBar;
    private List<Rigidbody> Balls;
    private bool ballPresent;
    
    // Start is called before the first frame update
    void Start()
    {
        launchBar.minValue = 0f;
        launchBar.maxValue = maxForce;
        Balls = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ballPresent)
        {
            launchBar.gameObject.SetActive(true);
        }
        else
        {
            launchBar.gameObject.SetActive(false);
        }
        launchBar.value = force;
        if (Balls.Count > 0)
        {
            ballPresent = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (force <= maxForce)
                {
                    force += 1800 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody i in Balls)
                {
                    i.AddForce(force*Vector3.left);
                }
            }
        }
        else
        {
            ballPresent = false;
            force = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Balls.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Balls.Remove(other.gameObject.GetComponent<Rigidbody>());
        force = 0f;
    }
}
