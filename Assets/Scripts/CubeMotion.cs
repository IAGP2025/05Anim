using UnityEngine;
using DG.Tweening;

public class CubeMotion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOLocalMove(Vector3.right * 1.0f, 2.0f)
            .SetDelay(3.0f)
            .SetEase(Ease.InOutCubic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
