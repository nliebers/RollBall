using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PortalScript : MonoBehaviour
{
    public GameObject[] pickups;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject redPillObject;
    public GameObject redPillObject02;
    public GameObject redPillObject03;
    public GameObject redPillObject04;
    public GameObject redPillObject05;
    public GameObject redPillObject06;
    public GameObject redPillObject07;
    public GameObject redPillObject08;
    public GameObject redPillObject09;
    public GameObject redPillObject10;
    public GameObject redPillObject11;
    public GameObject redPillObject12;
    public GameObject redPillObject13;

    void Start()
    {
        SetCountText();
        winTextObject.SetActive(false);
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winTextObject.SetActive(true);
        }
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

}

