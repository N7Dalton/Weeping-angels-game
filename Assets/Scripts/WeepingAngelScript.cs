using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        else {
            Debug.Log("Object is no longer visible");
                Enemy.transform.LookAt(player);
            Enemy.transform.Translate(0, 0, 5 * Time.deltaTime); 
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            lEye.SetActive(true);
            rEye.SetActive(true);
        }
        else
        {
            lEye.SetActive(false);
            rEye.SetActive(false);
        }
    }
}
