using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger4 : MonoBehaviour
{
    public GameObject plane4;
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
        if (target.name == "tri4")
        {
            Debug.Log("HIt it 4");
            //Anima.Play("");
            plane4.active = false;

        }
    }
}
