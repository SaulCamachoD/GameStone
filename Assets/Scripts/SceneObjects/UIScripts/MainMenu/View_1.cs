using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_1 : MonoBehaviour
{
    Controller_1 controller_1;
    public void inicializedView()
    {
        controller_1 = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<Controller_1>();
    }


    public void OnclickParameter(int viewParameter)
    {
        controller_1.Event(ref viewParameter);
    }
}
