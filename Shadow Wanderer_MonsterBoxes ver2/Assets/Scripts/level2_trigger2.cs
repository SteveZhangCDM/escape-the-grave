using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger2 : MonoBehaviour
{
    public GameObject plane2;
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
        if (target.name == "tri2")
        {
            Debug.Log("HIt it 2");
            //Anima.Play("");
            plane2.active = false;

        }
    }
}
