using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0f;
    public bool isPlayed = false;
    public Vector2 startPos;
    public Vector2 carPos;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        carPos = transform.position;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlayed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                audio.Play();
                Vector2 endPos = Input.mousePosition;
                float length = endPos.x - startPos.x;
                speed = length / 2000f;
                isPlayed = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            speed = 0f;
            transform.position = carPos;
            isPlayed = false;
        }

        //car.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        transform.Translate(speed, 0, 0);
        speed *= 0.97f;
    }
}
