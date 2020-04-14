using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTranslation : MonoBehaviour
{
    public GameObject otherObject;
    private Vector3 otherPos;

    private float movementRangeZ;
    private float movementRangeX;

    private float movementSpeed = 0.5f;
    private Vector3 objectPos;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movementRangeZ = transform.position.x;
        // movementRangeX = transform.position.z;
        


    }


    


    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");

            //update the position
            otherObject.transform.position = otherObject.transform.position + new Vector3(verticalInput * movementSpeed * Time.deltaTime, 0, horizontalInput * movementSpeed * Time.deltaTime);

        }
    }
}
