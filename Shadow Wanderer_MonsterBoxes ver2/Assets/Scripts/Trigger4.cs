using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger4 : MonoBehaviour
{
    //public GameObject collision1;
    //public Animator Anima;
    // Start is called before the first frame update
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