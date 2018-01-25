using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField]
    private float speed = 10;

    private Vector2 move;

    private void Update()
    {
        GetInputs();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        transform.Translate(move * speed * Time.deltaTime);
	}

    void GetInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        move = new Vector2(moveX, 0);
    }
}
