using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_1 : MonoBehaviour
{
    UIManager manager;
    View_1 view;
    public void inicialized()
    {
        manager = GameObject.FindGameObjectWithTag("ManagerMenu").GetComponent<UIManager>();
        view = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<View_1>();
        view.inicializedView();
    }

    public void Event(ref int controllerEvent)
    {
        manager.ScreenManagment(ref controllerEvent);   
    }


}