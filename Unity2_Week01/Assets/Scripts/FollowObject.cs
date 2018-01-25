using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{

    [SerializeField]
    private Transform objToFollow;
    [SerializeField]
    private float followSens = 5;
    [SerializeField]
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        FollowObjectTransform();
	}

    void FollowObjectTransform()
    {
        transform.position = Vector3.Lerp(transform.position, objToFollow.position + offset, Time.deltaTime * followSens);
    }
}
