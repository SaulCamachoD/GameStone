using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_2 : MonoBehaviour
{
    UIManager manager;
    View_2 view;
    public void inicialized()
    {
        manager = GameObject.FindGameObjectWithTag("ManagerMenu").GetComponent<UIManager>();
        view = GameObject.FindGameObjectWithTag("SettingsPanel").GetComponent<View_2>();
        view.inicializedView();
    }

    public void Event(ref int controllerEvent)
    {
        manager.ScreenManagment(ref controllerEvent);
    }
}
