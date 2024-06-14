using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewFinal : MonoBehaviour
{
    ControllerFinal controllerFinal;
    public void InicilizedViewGo()
    {
        controllerFinal = GameObject.FindGameObjectWithTag("FinalMenu").GetComponent<ControllerFinal>();
    }

    public void OnclickMainMenuReturn(int viewReference)
    {
        controllerFinal.Event(ref viewReference);
    }
}
