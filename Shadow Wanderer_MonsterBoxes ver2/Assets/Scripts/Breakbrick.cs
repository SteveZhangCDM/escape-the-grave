using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Breakbrick : MonoBehaviour
{
    public GameObject brick;
    public GameObject guideline;
    // Start is called before the first frame update
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
        if (target.name == "Cube")
        {
            brick.active = false;
            guideline.active = false;
        }
    }

}
