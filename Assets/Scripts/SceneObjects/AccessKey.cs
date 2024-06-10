
using UnityEngine;

public class AccessKey : MonoBehaviour
{   
    public BossDoor bossDoor;
    public GameObject[] gameObjectsWithKey1;
    private Key1[] key1Scripts;
    private const float epsilon = 0.0001f;
    private bool doorOpened = false;

    void Start()
    {
        key1Scripts = new Key1[gameObjectsWithKey1.Length];

        for (int i = 0; i < gameObjectsWithKey1.Length; i++)
        {
            
            key1Scripts[i] = gameObjectsWithKey1[i].GetComponent<Key1>();
     
        }
    }

    void Update()
    {
        if (!doorOpened && Mathf.Abs(key1Scripts[0].PositionKey - 300.0f) < epsilon && Mathf.Abs(key1Scripts[1].PositionKey - 240.0f) < epsilon && Mathf.Abs(key1Scripts[2].PositionKey - 60.0f) < epsilon)
        {
            bossDoor.ActiveDoorEvent();
            doorOpened = true;
        }

       
    }

}
