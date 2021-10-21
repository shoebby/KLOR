using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDprompt : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            gameObject.SetActive(false);
    }
}
