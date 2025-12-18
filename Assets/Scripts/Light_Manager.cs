using UnityEngine;
using System.Collections;

public class Light_Manager : MonoBehaviour
{
    [SerializeField]
    private Light directionalLight;

    public void SetStealthLight()
    {
        StopAllCoroutines();
        directionalLight.intensity = 0f;
        directionalLight.color = Color.white;
    }

    public void SetNormalLight()
    {
        StopAllCoroutines();
        directionalLight.intensity = 0.5f;
        directionalLight.color = Color.white;
    }

    public void SetAlertLight()
    {
        StartCoroutine(AlertRoutine());
        directionalLight.intensity = 0.25f;
    }

    IEnumerator AlertRoutine()
    {
        while (true)
        {
            directionalLight.color = Color.blue;
            yield return new WaitForSeconds(0.5f);

            directionalLight.color = Color.red;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
