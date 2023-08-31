using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillation : MonoBehaviour
{

    public float forwardSpeed = 2.0f;    // Kecepatan gerakan maju
    public float amplitude = 1.0f;   // Amplitudo dari osilasi
    public float frequency = 1.0f;   // Frekuensi osilasi

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Menghitung perpindahan objek berdasarkan waktu dan frekuensi osilasi
        float displacement = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * Time.time);

        // Update posisi objek berdasarkan perpindahan osilasi
        transform.position = initialPosition + Vector3.up * displacement;
        Vector3 movement = new Vector3(forwardSpeed,0f,0f);
        initialPosition = initialPosition + movement * Time.deltaTime;
    }
}
