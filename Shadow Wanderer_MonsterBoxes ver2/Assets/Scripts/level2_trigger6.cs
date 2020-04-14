using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger6 : MonoBehaviour
{
    public GameObject plane6;
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
        if (target.name == "tri6")
        {
            Debug.Log("HIt it 6");
            //Anima.Play("");
            plane6.active = false;

        }
    }
}
