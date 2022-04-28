using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;//Playerinn
    public Vector3 Offset;//Hversu langt þú vilt að myndavel sé frá player

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position + Offset; //Myndavelinn færir sig með playerinu
    }
}
