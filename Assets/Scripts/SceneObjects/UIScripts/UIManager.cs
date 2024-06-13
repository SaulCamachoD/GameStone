using UnityEngine;
using UnityEngine.SceneManagement   ;

public class UIManager : MonoBehaviour
{
    GameObject MainMenu;
    GameObject SettingsPanel;
    GameObject CreditsPanel;
    Controller_1 controller_1;
    Controller_2 controller_2;
    Controller_3 controller_3;
    void Start()
    {
        controller_1 = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<Controller_1>();
        controller_2 = GameObject.FindGameObjectWithTag("SettingsPanel").GetComponent<Controller_2>();
        controller_3 = GameObject.FindGameObjectWithTag("CreditsPanel").GetComponent<Controller_3>();

        MainMenu = GameObject.FindGameObjectWithTag("MainMenu");
        SettingsPanel = GameObject.FindGameObjectWithTag("SettingsPanel");
        CreditsPanel = GameObject.FindGameObjectWithTag("CreditsPanel");

        controller_1.inicialized();
        controller_2.inicialized();
        controller_3.inicialized();
        

        int n = 0;
        ScreenManagment(ref n);
    }

    public void ScreenManagment(ref int parameter)
    {
        TurnOffPanles();
        switch (parameter) 
        {
            case 0: MainMenu.SetActive(true); break;
            case 1: SceneManager.LoadScene("TutorialScene"); break;
            case 2: SettingsPanel.SetActive(true); break;
            case 3: CreditsPanel.SetActive(true); break;
            case 4: Application.Quit();print("Salio"); break;
            default: print("Ventana no existente" + parameter); break;
        }
    }

    public void TurnOffPanles()
    {
        MainMenu.SetActive(false);
        SettingsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }


}
