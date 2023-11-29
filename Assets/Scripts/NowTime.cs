using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NowTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hour, mintue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hour.text = DateTime.Now.ToString("hh½Ã");
        mintue.text = DateTime.Now.ToString("mmºÐ");
    }
}
