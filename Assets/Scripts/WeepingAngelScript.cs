using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class WeepingAngelScript : MonoBehaviour
{
    public NavMeshAgent ai;
    public FlashlightToggle flashtog;
    public GameObject enemy;
    public Renderer enemyRen;
    public Transform player;
    public GameObject lEye;
    public GameObject rEye;
    public BoxCollider eyeCollider;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (flashtog.isOn == false)
        {
            ai.SetDestination(player.position);
             
        }
        else if (!enemyRen.isVisible)
        {
            ai.SetDestination(player.position);
        }
        else
        {
            ai.SetDestination(enemy.transform.position);
        }
       
    }
   
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Death.");  
    }
    private void OnTriggerExit(Collider eyeCollider)
    {
        if (gameObject.CompareTag("Player"))
        {
            
            lEye.SetActive(false);
            rEye.SetActive(false);
        }

    }
    public void ChangeState()
    {
        
    }
}
