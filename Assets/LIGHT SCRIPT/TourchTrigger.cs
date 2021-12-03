using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchTrigger : MonoBehaviour
{
    [SerializeField] private GameObject FlashLight;
    [SerializeField] private GameObject Flash;
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlashLight.SetActive(true);
            Flash.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
