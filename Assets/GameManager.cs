using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject flag;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - player.transform.position.x;
        /*
        if (length < 0)
        {
            text.text = "���� ����";
        }
        else
        {
            text.text = "��ǥ �������� " + length.ToString("F2") + "m";
        }
        */
        text.text = "��ǥ �������� " + math.abs(length).ToString("F2") + "m";
    }
}
