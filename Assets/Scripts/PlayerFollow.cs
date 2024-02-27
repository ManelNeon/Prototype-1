using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    /// <Justifica��o>
    /// No tutorial dizem para meter a c�mara a seguir o jogador e colocar uma vari�vel offset, na minha opini�o, fica melhor ter um empty dentro do jogador que tem a 
    /// localiza��o que pretendo para a c�mara e meter apenas a posi��o igual a esse empty object. Acaba por ter o mesmo efeito mas com um c�digo mais simples e melhor.
    /// </Justifica��o>
    
    [SerializeField] GameObject cameraSpot;

    [SerializeField] GameObject player;

    void LateUpdate()
    {
        this.transform.position = cameraSpot.transform.position;

        transform.LookAt(player.transform);
    }
}
