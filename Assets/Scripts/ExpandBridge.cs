using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandBridge : MonoBehaviour
{
    private bool isToching = false;
    //private bool stopResizing = false;

    public bool inverse;
    public float reziseAmount; 
    public string resizeDirection; //x y z
    public float maxScale = 3.0f; // Припустимо, що максимальний розмір - 10

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (isToching)
        {
            Debug.Log("resize bridge...");
            Resize(reziseAmount, resizeDirection);
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player pressed button");
            isToching = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player stop press button");
            isToching = false;
        }
    }
    void Resize(float amount, string direction)
    {
        switch (direction)
        {
            case "x":
                if (!inverse)
                {
                    float newScaleX = transform.localScale.x + amount;
                    float newPositionX = transform.position.x + (amount / 2);

                    // Перевіряємо, чи не перевищено максимальний розмір
                    if (newScaleX <= maxScale)
                    {
                        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
                        transform.localScale = new Vector3(newScaleX, transform.localScale.y, transform.localScale.z);
                    }
                   
                }
                else
                {
                    transform.position = new Vector3(transform.position.x - (amount / 2), transform.position.y, transform.position.z);
                    transform.localScale = new Vector3(transform.localScale.x + amount, transform.localScale.y, transform.localScale.z);
                }
                break;

            case "y":
                if (!inverse)
                {
                    float newScaleY = transform.localScale.y + amount;
                    float newPositionY = transform.position.y + (amount / 2);
                    if (newScaleY <= maxScale)
                    {
                        transform.position = new Vector3(transform.position.x, newPositionY, transform.position.z);
                        transform.localScale = new Vector3(transform.localScale.x, newScaleY, transform.localScale.z);
                    }
                   
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - (amount / 2), transform.position.z);
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + amount, transform.localScale.z);
                }
                break;

            case "z":
                if (!inverse)
                {
                    float newScaleZ = transform.localScale.z + amount;
                    float newPositionZ = transform.position.z + (amount / 2);
                    if (newScaleZ <= maxScale)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ);
                        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, newScaleZ);
                    }
                    
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (amount / 2));
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + amount);
                }
                break;

            default:
                Debug.LogWarning("Invalid direction: " + direction);
                break;
        }

    }
}
