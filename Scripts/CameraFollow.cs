using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;//Playerinn
    public Vector3 Offset;//Hversu langt �� vilt a� myndavel s� fr� player

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position + Offset; //Myndavelinn f�rir sig me� playerinu
    }
}
