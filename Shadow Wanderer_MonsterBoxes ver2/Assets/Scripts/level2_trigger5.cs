using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger5 : MonoBehaviour
{
    public GameObject plane5;
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
        if (target.name == "tri5")
        {
            Debug.Log("HIt it 5");
            //Anima.Play("");
            plane5.active = false;

        }
    }
}
