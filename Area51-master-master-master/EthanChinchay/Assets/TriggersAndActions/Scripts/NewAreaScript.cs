using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAreaScript : MonoBehaviour
{

    public Light targetLight;
    public Color TargetColor;
    public Color OriginaltargetColor;
    public bool runUpdate;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !runUpdate)
        {
            runUpdate = true;
            {
                targetLight.enabled = true;
                targetLight.color = TargetColor;

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            runUpdate = false; {

                targetLight.enabled = true;
                targetLight.color = OriginaltargetColor;

            }
        }
    }
}
