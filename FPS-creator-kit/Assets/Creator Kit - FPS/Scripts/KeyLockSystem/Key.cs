using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{

    public GameObject wave;
    public string keyType;
    public Text KeyNameText;   

    void OnEnable()
    {
        KeyNameText.text = keyType;
    }

    void OnTriggerEnter(Collider other)
    {
        var keychain = other.GetComponent<Keychain>();

        if (keychain != null)
        {
            keychain.GrabbedKey(keyType);
            wave.SetActive(true);
            Destroy(gameObject);
        }
    }
}
