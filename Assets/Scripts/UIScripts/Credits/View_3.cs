using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_3 : MonoBehaviour
{
    Controller_3 controller_3;
    public void inicializedView()
    {
        controller_3 = GameObject.FindGameObjectWithTag("CreditsPanel").GetComponent<Controller_3>();
    }


    public void OnclickParameter(int viewParameter)
    {
        controller_3.Event(ref viewParameter);
    }
}
