using UnityEngine;

public class DemoCamera : MonoBehaviour
{
    [SerializeField] private float _sinusMultiplier;
    [SerializeField] private float _amplitudeX;

    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        Vector3 resultVector = _startPos;
        float sin = Mathf.Sin(Time.time * _sinusMultiplier);
        resultVector.x += _amplitudeX * sin;
        transform.position = resultVector;
    }
}