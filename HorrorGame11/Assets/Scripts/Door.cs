using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    // Referência ao segundo objeto (adicione no Inspector do Unity)
    public Transform objetoAlvo;
    private AudioSource porta;
    public float tempo;
    void Start()
    {
        porta = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (objetoAlvo != null)
        {
            // Calcula a distância entre este objeto e o objetoAlvo
            float distancia = Vector3.Distance(transform.position, objetoAlvo.position);

            // Exibe a distância no console
            Debug.Log("A distância é: " + distancia);
            if (distancia < 3)
            {
                porta.enabled = true;
                StartCoroutine(LigarSom());
            }
        }
    }
    private IEnumerator LigarSom()
    {
        yield return new WaitForSeconds(tempo);
        porta.enabled = false;
    }
}
