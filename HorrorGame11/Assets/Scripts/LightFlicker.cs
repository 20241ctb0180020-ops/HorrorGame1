using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour
{
    private Light luz;
    public float tempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        luz = GetComponent<Light>();
        StartCoroutine(LigarLamp());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator LigarLamp()
    {
        luz.enabled = false;
        Debug.Log("Iniciou a ação!");
        
        yield return new WaitForSeconds(tempo);
        
        Debug.Log("Terminou a espera de " + tempo + " segundos!");
        luz.enabled = true;

        yield return new WaitForSeconds(tempo);

        StartCoroutine(LigarLamp());
    }
}
