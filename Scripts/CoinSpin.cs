using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 _rotation;//velur hva� �a� sn�st hratt

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);//Sn�r coininu � hringi
    }
}
