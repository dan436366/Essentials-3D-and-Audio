using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time in seconds for a full 360° rotation (a full day)")]
    [Range(10f, 86400f)]
    public float secondsPerDay = 60f;

    void Update()
    {
        // Calculate degrees per second
        float degreesPerSecond = 360f / secondsPerDay;

        // Rotate around the X axis
        transform.Rotate(Vector3.right * degreesPerSecond * Time.deltaTime);
    }
}