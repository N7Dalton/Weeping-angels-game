using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeepingAngelScript : MonoBehaviour
{
    public GameObject Enemy;
    public Renderer enemyRen;
    public Transform player;
    public GameObject lEye;
    public GameObject rEye;
    public BoxCollider eyeCollider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (enemyRen.isVisible)
        {
            Debug.Log("Object is visible");

        }
        else
        {
            Debug.Log("Object is no longer visible");
            Enemy.transform.LookAt(player);
            Enemy.transform.Translate(0, 0, 5 * Time.deltaTime);
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
}
