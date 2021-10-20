using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamIllustrationTrigger : MonoBehaviour
{
    public GameObject relatedText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        relatedText.SetActive(true);
    }
}
