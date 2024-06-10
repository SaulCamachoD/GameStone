using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_3 : MonoBehaviour
{
    UIManager manager;
    View_3 view;
    public void inicialized()
    {
        manager = GameObject.FindGameObjectWithTag("ManagerMenu").GetComponent<UIManager>();
        view = GameObject.FindGameObjectWithTag("CreditsPanel").GetComponent<View_3>();
        view.inicializedView();
    }

    public void Event(ref int controllerEvent)
    {
        manager.ScreenManagment(ref controllerEvent);   
    }
}
