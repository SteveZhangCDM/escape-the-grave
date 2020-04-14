using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger3 : MonoBehaviour
{
    public GameObject plane3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Obsolete]
    private void OnTriggerStay(Collider target)
    {
        if (target.name == "tri3")
        {
            Debug.Log("HIt it 3");
            //Anima.Play("");
            plane3.active = false;

        }
    }
}
