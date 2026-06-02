using UnityEngine;
using System.Collections;

public class Body : MonoBehaviour
{
    Rigidbody massa;
    public Transform objetoAlvo;
    private AudioSource body;
    public float tempo1;
    private int number1 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        massa = GetComponent<Rigidbody>();
        body = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objetoAlvo != null)
        {
            // Calcula a distância entre este objeto e o objetoAlvo
            float distanciaPlayer = Vector3.Distance(transform.position, objetoAlvo.position);
            Debug.Log("A distância é: " + distanciaPlayer);
            if (distanciaPlayer < 2.7)
            {
                if(number1 <1 )
                {
                massa.useGravity = true;
                body.enabled = true;
                StartCoroutine(LigarSom());
                }
            }
        }
    }
    private IEnumerator LigarSom()
    {
        yield return new WaitForSeconds(tempo1);
        body.enabled = false;
        number1 += 1;
    }
}
