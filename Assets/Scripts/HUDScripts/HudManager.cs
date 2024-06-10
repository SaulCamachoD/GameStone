using UnityEngine;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{

    GameObject GameOverMenu;
    Controller_GO controller_Go;
    void Start()
    {
        controller_Go = GameObject.FindGameObjectWithTag("GameOverMenu").GetComponent<Controller_GO>();
        GameOverMenu = GameObject.FindGameObjectWithTag("GameOverMenu");

        GameOverMenu.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            ActivationGameOverMenu();
        }


    }


    public void ActivationGameOverMenu()
    {

        GameOverMenu.SetActive(true);
        controller_Go.InicializedControllerGo();
        Time.timeScale = 0.0f;
    }

    public void ActionGameOverMenu(ref int controllerparameter)
    {
        if (controllerparameter == 0)
        {
            SceneManager.LoadScene("UIScene");
            Time.timeScale = 1.0f;
        }

        if (controllerparameter == 1)
        {
            SceneManager.LoadScene("GameMainScene");
            Time.timeScale = 1.0f;
        }

        if (controllerparameter == 2)
        {
            GameOverMenu.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void StartMainScene()
    {
        SceneManager.LoadScene("GameMainScene");

    }
}
