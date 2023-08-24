using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject lightGO; //light gameObject to work with
    public bool isOn = false; //is flashlight on or off?
    public int power = 100;
    public int powerWasted = 1;
    bool BatDead = false;
    public bool canTurnOn = true;
    public Material powerLightOn;
    public Material powerLightOff;
    public GameObject powerLight;
    // Use this for initialization
    void Start()
    {
        //set default off
        lightGO.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn) 
        { 
            power =power - powerWasted;
        }
        if(power == 0 && BatDead == false)
        {
            isOn = false;
            BatDead = true;
            powerLight.GetComponent<Renderer>().material = powerLightOff;
           StartCoroutine(ChargeBattery());
            Debug.Log("shouldd have ran chargeBattery code");
        }
        if (isOn)
        {
            lightGO.SetActive(true);
        }
        //turn light off
        else
        {
            lightGO.SetActive(false);

        }
        //toggle flashlight on key down
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(power != 0)
            {
                isOn = !isOn;
            }
            else
            {
                isOn = false;
            }
           
        }
        IEnumerator ChargeBattery()
        {
            Debug.Log("chargeBattery is running");
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(4);
            power = 300;
            BatDead=false;
            powerLight.GetComponent<Renderer>().material = powerLightOn;
            Debug.Log($"Power {power}");
        }
    }
}
