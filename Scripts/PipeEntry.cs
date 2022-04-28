using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEntry : MonoBehaviour
{

    public GameObject pipeCollider;
    public int StoodOn;

    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject MainPlayer;
    public GameObject FadeScreen;
    public AudioSource PipeSound;

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;//Checkar ef maður stendur á pipeinu
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("GoDown"))//ef það er ytt á "S" Fer Waiting for pipe i gang
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeSound.Play();//Spilar hljoð
        FadeScreen.SetActive(true);//Activatar canvas
        pipeCollider.GetComponent<Animator>().enabled = true;//Animator fer i gang og maður fer ofan í pipeið
        yield return new WaitForSeconds(1.5F);
        FadeScreen.GetComponent<Animator>().enabled = true;//Canvas Animator fer i gang
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;//Canvas animator hættir
        pipeCollider.GetComponent<Animator>().enabled = false;//pipe animation fer i stip
        SecondCam.SetActive(true);//Ivan camera fer i gang
        MainCam.SetActive(false);//Slökkt á maincam
        MainPlayer.transform.position = new Vector3(12, -17, 1);//Færir player i underworld
        FadeScreen.GetComponent<Animator>().enabled = true;//Canvas anim fer i gang
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;//Canvas anim stöðvar
        FadeScreen.SetActive(false);//Canvas deactiavteað
    }
}