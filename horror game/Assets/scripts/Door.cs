using UnityEngine;

public class Door : MonoBehaviour
{
     public Transform alvo;

    void Update()
    {
        if (alvo != null)
        {
            // Calcula a distância entre os dois objetos
            float distancia = Vector3.Distance(transform.position, alvo.position);

            // Exibe a distância no console do Unity
            Debug.Log("A distância até o alvo é: " + distancia);
        }
    }
}
