using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Update is called once per frame
    private void Update()
    {
        //Follows player only on x axis
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
