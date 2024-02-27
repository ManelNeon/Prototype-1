using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    /// <Justificação>
    /// No tutorial dizem para meter a câmara a seguir o jogador e colocar uma variável offset, na minha opinião, fica melhor ter um empty dentro do jogador que tem a 
    /// localização que pretendo para a câmara e meter apenas a posição igual a esse empty object.
    /// </Justificação>
    
    [SerializeField] GameObject cameraSpot;

    void LateUpdate()
    {
        this.transform.position = cameraSpot.transform.position;
    }
}
