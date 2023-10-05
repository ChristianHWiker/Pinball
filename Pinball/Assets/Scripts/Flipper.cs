using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float defaultPos = 0f;
    public float maxPos = 45f;
    public float flipperForce = 10000f;
    public float flipperDamper = 150f;

    public string input;
    private HingeJoint hinge;
    
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = flipperForce;
        spring.damper = flipperDamper;
        
        if (Input.GetAxis(input) == 1)
        {
            spring.targetPosition = maxPos;
            print("input detected");
        }
        else
        {
            spring.targetPosition = defaultPos;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
