using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_2 : MonoBehaviour
{
    Controller_2 controller_2;
    public void inicializedView()
    {
        controller_2 = GameObject.FindGameObjectWithTag("SettingsPanel").GetComponent<Controller_2>();
    }


    public void OnclickParameter(int viewParameter)
    {
        controller_2.Event(ref viewParameter);
    }
}
