using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration of a full day in seconds (editable in Inspector)
    [SerializeField] private float dayDuration = 120f;

    // Update is called once per frame
    void Update()
    {
        // Calculate rotation speed based on the duration of a full day
        float rotationSpeed = 360f / dayDuration;

        // Rotate the light over time to simulate day passing
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
