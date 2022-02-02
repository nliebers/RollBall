using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PortalScript : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject startText;
    public GameObject finalGround;
    public GameObject resetText;
    public static bool reset = false;

    void Start()
    {
        SetCountText();
        winTextObject.SetActive(false);
        resetText.SetActive(false);
        Invoke("DisableStartPanel", 5f);
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winTextObject.SetActive(true);
            finalGround.SetActive(true);
        }
    }

    void DisableStartPanel()
    {
        startText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void Update()
    {
        if(reset == true)
        {
            count = 0;
            SetCountText();  
            reset = false;
        }
        
    }

}

