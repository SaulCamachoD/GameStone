using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_GO : MonoBehaviour
{
    Controller_GO controllerGo;
    public void InicilizedViewGo()
    {
        controllerGo = GameObject.FindGameObjectWithTag("GameOverMenu").GetComponent<Controller_GO>();
    }

    public void OnclickMainMenuReturn(int viewReference)
    {
        controllerGo.Event(ref viewReference);
    }
}
