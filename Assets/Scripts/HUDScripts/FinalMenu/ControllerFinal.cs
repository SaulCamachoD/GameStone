using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFinal : MonoBehaviour
{
    HudManager hudManager;
    ViewFinal viewFinal;
    public void InicializedControllerGo()
    {
        hudManager = GameObject.FindGameObjectWithTag("HudManager").GetComponent<HudManager>();
        viewFinal = GameObject.FindGameObjectWithTag("FinalMenu").GetComponent<ViewFinal>();
        viewFinal.InicilizedViewGo();
    }

    public void Event(ref int viewParameter)
    {
        hudManager.ActionGameOverMenu(ref viewParameter);
    }
}
