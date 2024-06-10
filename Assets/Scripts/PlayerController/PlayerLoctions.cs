using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLoctions : MonoBehaviour
{
    private float Xinicial;
    private float Yinicial;
    private float Zinicial;
    private float Xcurrent;
    private float Ycurrent;
    private float Zcurrent;
    private float XdoorBoss;
    private float YdoorBoss;
    private float ZdoorBoss;
    public bool isPlayerResetting = false;
    public bool ZonaBoss = false;
    public RestoreItems restoreItems;
    PlayerVariables playerVariables;

    Attack attack;
    void Start()
    {
        Xinicial = transform.position.x;
        Yinicial = transform.position.y;
        Zinicial = transform.position.z;
        attack = GetComponent<Attack>();
        playerVariables = GetComponent<PlayerVariables>();  

    }

    public void InicialLocation()
    {
        transform.position = new Vector3(Xinicial, Yinicial, Zinicial);
    }
    
    public void CheckPointBoss( Vector3 position)
    {
        XdoorBoss = position.x;
        YdoorBoss = position.y;
        ZdoorBoss = position.z;
    }

    public void CurrentLocation(Vector3 location)
    {
        Xcurrent = location.x;
        Ycurrent = location.y;
        Zcurrent = location.z;
    }

    public void DoorBossLocation()
    {
        transform.position = new Vector3(XdoorBoss, YdoorBoss + 0.5f, ZdoorBoss);
    }
    public void EventBoss(bool inFightBoos)
    {
        ZonaBoss = inFightBoos;
    }

    public void ReLocation()
    {
        if (ZonaBoss)
        {
            if (playerVariables.health <= 25f && !isPlayerResetting)
            {
                isPlayerResetting = true;
                attack.Damage(25f);
                StartCoroutine(InicialPlayerBossPosition());
            }
            else if ( !isPlayerResetting)
            {
                transform.position = new Vector3(Xcurrent, Ycurrent + 0.5f, Zcurrent);
                attack.Damage(25f);
            }
        }
        else
        {
            if (playerVariables.health <= 25f)
            {
                attack.Damage(25f);
                StartCoroutine(InicialPlayer());
            }
            else
            {
                transform.position = new Vector3(Xcurrent, Ycurrent + 0.5f, Zcurrent);
                attack.Damage(25f);
            }
        }
    }

    IEnumerator InicialPlayer()
    {
        
        yield return new WaitForSeconds(0.5f);
        InicialLocation();
        restoreItems.ResetPlayerHeatlh();
        yield return null;
    }
    
    IEnumerator InicialPlayerBossPosition()
    {
        yield return new WaitForSeconds(0.5f);
        DoorBossLocation();
        restoreItems.ResetPlayerHeatlh();
        isPlayerResetting = true;
        yield return null;
    }


}
