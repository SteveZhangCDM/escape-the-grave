using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_trigger7 : MonoBehaviour
{
    public GameObject plane7;
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
        if (target.name == "tri7")
        {
            Debug.Log("HIt it 7");
            //Anima.Play("");
            plane7.active = false;

        }
    }
}
