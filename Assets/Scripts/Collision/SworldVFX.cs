using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.VFX;

public class SworldVFX : MonoBehaviour
{
    public VisualEffect swordVFX;
    // Start is called before the first frame update
    void Start()    
    {
        
    }
    public void AttackStart()
    {
        if (swordVFX)
        {
            swordVFX.gameObject.SetActive(true);
            StartCoroutine(DeactivateVFXAfterDelay(0.5f));
        }
    }

    public void AttackEnd()
    {
        if (swordVFX)
        {
            // Aquí puedes agregar lógica adicional si es necesario
        }
    }

    // Corutina para desactivar el VFX después de un retraso
    private IEnumerator DeactivateVFXAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        swordVFX.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AttackStart();
    }
    // Update is called once per frame
    
}
