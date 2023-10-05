using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUpdate : MonoBehaviour
{ 
    public TextMeshPro textComponent; // Reference to the Text component

    private void Start()
    {
        // Assuming you've already set up the reference in the Inspector.
        // You can also find the Text component using GetComponent if needed.
    }

    // Function to update the text with an integer value
    public void UpdateText(int value)
    {
        textComponent.text = "Value: " + value.ToString(); // Convert int to string
    }
}