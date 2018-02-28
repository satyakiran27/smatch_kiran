using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class VRbutton: MonoBehaviour, IVirtualButtonEventHandler
{ 
   
    private GameObject fun;
    private GameObject call;
    private GameObject clock;


    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
            Debug.Log(vbs[i].name);
        }


        fun = transform.Find("Gangnamstyle").gameObject;
        call = transform.Find("Ring").gameObject;
        clock = transform.Find("Clock").gameObject;

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       

        switch (vb.VirtualButtonName)
        {
            case "Fun":
                fun.SetActive(true);
                clock.SetActive(false);
                Debug.Log("BTN Pressed fun");
                StartCoroutine(delay());
                Debug.Log("Log the ID of my trackable: " + vb.name);
                break;
            case "Call":
                call.SetActive(true);
                clock.SetActive(false);
                Debug.Log("Log the ID of my trackable: " + vb.name);
                Debug.Log("BTN Pressed call");
                StartCoroutine(delay_1());
                break;
           
        }


    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(12);
        fun.SetActive(false);
        clock.SetActive(true);
    }
    IEnumerator delay_1()
    {
        yield return new WaitForSeconds(5);
        call.SetActive(false);
        clock.SetActive(true);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log(" BTN Realesed");

    }


    // Update is called once per frame
    void Update()
    {

    }
   

}
