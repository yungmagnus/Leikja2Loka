using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMove : MonoBehaviour
{
    public float LeftPoint = 30;//Segir hversu langt �� kemst ��ur en �vinur sn�r vi�.
    public float RightPoint = 50;
    public int Direction = 1;

    void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World); //F�rir kalinn til h�gri
            Direction = 1;
        }
        if (this.transform.position.x > RightPoint) // �egar kominn � lengsta punkt sn�r vi�.
        {
            Direction = 2;
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }
        if (this.transform.position.x < LeftPoint)
        {
            Direction = 1;
        }
    }
}