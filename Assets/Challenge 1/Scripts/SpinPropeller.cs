using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float spinSpeed = 1.0f; // Speed for rotate the Propeller
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed); // Function to spin the Propeller in base of the spinSpeed
    }
}
