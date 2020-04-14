using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    //public GameObject collision1;
    //public Animator Anima;
    // Start is called before the first frame update
    public GameObject plane1;
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
        if (target.name == "tri1")
        {
            Debug.Log("HIt it 1");
            //Anima.Play("");
            plane1.active = false;

        }
    }
}
