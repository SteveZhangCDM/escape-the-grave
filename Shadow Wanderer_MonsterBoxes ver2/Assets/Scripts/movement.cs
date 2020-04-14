using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private int State;//
    private int oldState = 0;//
    private int UP = 0;//
    private int RIGHT = 1;//
    private int DOWN = 2;//
    private int LEFT = 3;//

    public float speed = 2;

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey("w") | Input.GetKey("up"))
        {
            setState(UP);
        }
        else if (Input.GetKey("s") | Input.GetKey("down"))
        {
            setState(DOWN);
        }

        if (Input.GetKey("a") | Input.GetKey("left"))
        {
            setState(LEFT);
        }
        else if (Input.GetKey("d") | Input.GetKey("right"))
        {
            setState(RIGHT);
        }

    }


    void setState(int currState)
    {
        Vector3 transformValue = new Vector3();//
        int rotateValue = (currState - State) * 90;

        switch (currState)
        {
            case 0://
                transformValue = Vector3.forward * Time.deltaTime * speed;
                break;
            case 1://
                transformValue = Vector3.right * Time.deltaTime * speed;
                break;
            case 2://
                transformValue = Vector3.back * Time.deltaTime * speed;
                break;
            case 3://
                transformValue = Vector3.left * Time.deltaTime * speed;
                break;
        }
        transform.Rotate(Vector3.up, rotateValue);//
        transform.Translate(transformValue, Space.World);//
        oldState = State;//
        State = currState;//
    }

}
