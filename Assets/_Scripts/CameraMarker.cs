using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMarker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sign;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        sign.SetText(dist.ToString());
    }
}
