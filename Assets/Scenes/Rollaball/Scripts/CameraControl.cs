using UnityEngine;

public class CameraControl : MonoBehaviour
{
        [SerializeField] private GameObject player;
        vector3 distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player:" + player.transform.position);
        Debug.Log("Camera:" +trnasform.position);

        distance = transform.position - transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player:" + player.transform.position);
        distance
        
    }
}
