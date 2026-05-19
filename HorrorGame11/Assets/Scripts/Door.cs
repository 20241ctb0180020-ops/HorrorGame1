using UnityEngine;

public class Door : MonoBehaviour
{
    // Referência ao segundo objeto (adicione no Inspector do Unity)
    public Transform objetoAlvo;

    void Update()
    {
        if (objetoAlvo != null)
        {
            // Calcula a distância entre este objeto e o objetoAlvo
            float distancia = Vector3.Distance(transform.position, objetoAlvo.position);

            // Exibe a distância no console
            Debug.Log("A distância é: " + distancia);
            if ()
        }
    }
}
