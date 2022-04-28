using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeExit : MonoBehaviour
{

    public AudioSource PipeSound;
    public GameObject FadeScreen;
    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject PipeEntry;
    public GameObject MainPlayer;


    IEnumerator OnTriggerEnter(Collider col)
    {
        PipeSound.Play();//Spilar PipeSound
        yield return new WaitForSeconds(0.495F);
        FadeScreen.SetActive(true);//Activatar Canvasinn
        FadeScreen.GetComponent<Animator>().enabled = true;//Activatar animatorinn � canvas
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;// slekkur � Canvas
        MainCam.SetActive(true);//Skiptir yfir � maincamera
        SecondCam.SetActive(false);//slekkur � ivan camera
        MainPlayer.transform.position = new Vector3(27,1.8F, 0.5F); //F�rir playerinn � seinna pipei�  
        PipeEntry.GetComponent<Animator>().enabled = true;//PipeAnimaion f�rir playerinn upp
        FadeScreen.GetComponent<Animator>().enabled = true;//Canvas fer � gang
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;//St��var canvas animation
        yield return new WaitForSeconds(1);
        PipeEntry.GetComponent<Animator>().enabled = false;//Sto�var mann ofan � pipe.
        FadeScreen.SetActive(false);//Slekkur � Canvas
    }
}