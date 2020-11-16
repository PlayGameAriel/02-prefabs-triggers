using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* public static float Clamp(float value, float min, float max);
 * Returns:
 *float The float result between the min and max values.
 */
public class StayInside : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f),
            Mathf.Clamp(transform.position.y, -4f, 4f),transform.position.z); 
    }
}
