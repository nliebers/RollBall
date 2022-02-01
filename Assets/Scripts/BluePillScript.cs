using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BluePillScript : MonoBehaviour
{
    public GameObject pickup1;
    public GameObject pickup2;
    public GameObject pickup3;
    public GameObject pickup4;
    public GameObject pickup5;
    public GameObject pickup6;
    public GameObject pickup7;
    public GameObject pickup8;
    public GameObject player;
    public GameObject resetText;
    private float y = 0.5f;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            pickup1.transform.position = new Vector3(7f, y, 0f);
            pickup2.transform.position = new Vector3(6.5f, y, 5f);
            pickup3.transform.position = new Vector3(-1.5f, y, 5f);
            pickup4.transform.position = new Vector3(-4f, y, -1.5f);
            pickup5.transform.position = new Vector3(-8f, y, -4.5f);
            pickup6.transform.position = new Vector3(0f, y, -5f);
            pickup7.transform.position = new Vector3(-9f, y, 1f);
            pickup8.transform.position = new Vector3(7.5f, y, -9f);
            player.transform.position = new Vector3(0f, y, 0f);
            resetText.SetActive(true);
            Invoke("DisableResetPanel", 3f);
        }
    }
    void DisableResetPanel()
    {
        resetText.SetActive(false);
    }

}
