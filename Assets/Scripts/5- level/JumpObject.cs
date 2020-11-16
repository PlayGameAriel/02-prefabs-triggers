using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*When the player reaches one side of the world' he appears on the other side*/
public class JumpObject : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x == -8f || transform.position.x == 8f)
        {

            transform.position = -transform.position;
        }
        else if (transform.position.y == -4f || transform.position.y == 4f)
        {

            transform.position = -transform.position;
        }

    }
}


