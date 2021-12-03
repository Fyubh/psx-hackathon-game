using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Note;
    private PlayerController PlayerController;
    // Start is called before the first frame update
    private void Start()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.isReadNode = true;
            Note.SetActive(true);
            StartCoroutine(NodeTimer());
        }
    }

    IEnumerator NodeTimer()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        Note.SetActive(false);
        PlayerController.isReadNode = false;
    }
}
