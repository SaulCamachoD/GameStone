using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_GO : MonoBehaviour
{
    HudManager hudManager;
    View_GO view_GO;
    public void InicializedControllerGo()
    {
        hudManager = GameObject.FindGameObjectWithTag("HudManager").GetComponent<HudManager>();
        view_GO = GameObject.FindGameObjectWithTag("GameOverMenu").GetComponent<View_GO>();
        view_GO.InicilizedViewGo();
    }

    public void Event(ref int viewParameter)
    {
        hudManager.ActionGameOverMenu(ref viewParameter);
    }
}
