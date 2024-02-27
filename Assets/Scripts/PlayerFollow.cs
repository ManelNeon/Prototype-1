using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    /// <Justifica��o>
    /// No tutorial dizem para meter a c�mara a seguir o jogador e colocar uma vari�vel offset, na minha opini�o, fica melhor ter um empty dentro do jogador que tem a 
    /// localiza��o que pretendo para a c�mara e meter apenas a posi��o igual a esse empty object.
    /// </Justifica��o>
    
    [SerializeField] GameObject cameraSpot;

    void LateUpdate()
    {
        this.transform.position = cameraSpot.transform.position;
    }
}
