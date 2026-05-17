using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour
{
    Light luz;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        luz = gameObject.GetComponent<Light>();
        StartCoroutine(LigarLamp());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ligar()
    {
     
    }
    IEnumerator LigarLamp()
    {
        luz.Light = false;
        Debug.Log("Iniciou a ação!");
        
        yield return new WaitForSeconds(1f);
        
        Debug.Log("Terminou a espera de 1 segundos!");
        luz.Light = true;
        Ligar();
    }
}
