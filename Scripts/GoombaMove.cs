using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMove : MonoBehaviour
{
    public float LeftPoint = 30;//Segir hversu langt þú kemst áður en óvinur snýr við.
    public float RightPoint = 50;
    public int Direction = 1;

    void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World); //Færir kalinn til hægri
            Direction = 1;
        }
        if (this.transform.position.x > RightPoint) // Þegar kominn á lengsta punkt snýr við.
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