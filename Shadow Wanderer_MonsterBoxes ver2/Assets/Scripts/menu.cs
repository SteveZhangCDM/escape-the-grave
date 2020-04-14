using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject popmenu;

    [System.Obsolete]
    private void OnTriggerStay(Collider target)
    {
        if (target.name == "Player")
        {
            popmenu.active = true;
        }
    }
}
