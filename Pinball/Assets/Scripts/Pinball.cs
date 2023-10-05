using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Import the TextMeshPro namespace

public class Pinball : MonoBehaviour
{
    Rigidbody rb;
    float speed = 1;
    int PointTotal = 0;
    public Obstacle obstacle;
    public TextMeshProUGUI textElement; // Reference to the TextMeshProUGUI element on the Canvas

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textElement = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        rb.velocity = speed * rb.velocity;
        if (speed > 1)
        {
            speed = speed = 1;
            
        }
        textElement.text = "pointTotal: \n" + PointTotal.ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Killzone")
        {
            print("Killzone hit");
            SceneManager.LoadScene("MenuScene");
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            print("Is Obstacle");
            Obstacle scriptComponent = other.gameObject.GetComponent<Obstacle>();

            if (scriptComponent != null)
            {
                print("Has script");
                float intValue = scriptComponent.speed;
                Debug.Log("Named Int Value: " + intValue);
                int pointAddition = scriptComponent.pointValue;

                speed = intValue;
                PointTotal += pointAddition;
                print("PointTotal: " + PointTotal);
            }
        }
    }
}
