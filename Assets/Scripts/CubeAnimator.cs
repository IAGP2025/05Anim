using UnityEngine;

public class CubeAnimator : MonoBehaviour
{
    Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _animator.SetTrigger("TriggerX");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _animator.SetTrigger("TriggerY");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _animator.SetTrigger("TriggerZ");
        }
    }
}
