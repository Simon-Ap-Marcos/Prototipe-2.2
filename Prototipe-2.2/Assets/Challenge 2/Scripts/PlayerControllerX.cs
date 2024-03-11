using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeFire = 1;
    private float timeUpdate = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeUpdate)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeUpdate = Time.time + timeFire;
        }
    }
}
