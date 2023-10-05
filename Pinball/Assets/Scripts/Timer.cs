using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private bool stopTimer = false;
    float time;
    public Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTimer == false)
        {
            time = Time.deltaTime;
        }

        timeText.text = time.ToString();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            stopTimer = false;
        }
    }
}
