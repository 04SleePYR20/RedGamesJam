using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _objects;
    [SerializeField] Camera _camera;
    [SerializeField] int _offsetX;
    [SerializeField] int _offsetY;
    [SerializeField] float _spawnDistance = 10f; // The distance from the camera where the object can spawn.
    [SerializeField] float _chanceOfDoubleSpawn = 0.3f; // The probability of spawning two objects (0.0f to 1.0f).

    GameObject _spawnedObject;

    float _randomAngle; // Added to store the random angle for spawn direction.


    void Start()
    {
        Spawn();
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Spawn();
    //    }
    //}

    void Spawn()
    {
        if (Random.value <= _chanceOfDoubleSpawn)
        {
            SpawnTwoObjects();
        }
        else
        {
            SpawnSingleObject();
        }
    }

    void SpawnSingleObject()
    {
        int randomObjectId = Random.Range(0, _objects.Length);
        Vector2 position = GetRandomCoordinates();

        _spawnedObject = Instantiate(_objects[randomObjectId], position, Quaternion.identity) as GameObject;
    }

    void SpawnTwoObjects()
    {
        int randomObjectId1 = Random.Range(0, _objects.Length);
        int randomObjectId2 = Random.Range(0, _objects.Length);

        Vector2 position1 = GetRandomCoordinates();
        Vector2 position2 = GetRandomCoordinates();

        _spawnedObject = Instantiate(_objects[randomObjectId1], position1, Quaternion.identity) as GameObject;
        _spawnedObject = Instantiate(_objects[randomObjectId2], position2, Quaternion.identity) as GameObject;
    }

    Vector2 GetRandomCoordinates()
    {
        Vector2 cameraPosition = _camera.transform.position;

        Vector2 position;

        // Keep generating random positions until the spawn position is outside the camera view.
        do
        {
            // Generate a random angle in radians.
            _randomAngle = Random.Range(0f, 2f * Mathf.PI);

            // Calculate the spawn position outside the camera's view.
            float spawnX = cameraPosition.x + Mathf.Cos(_randomAngle) * _spawnDistance;
            float spawnY = cameraPosition.y + Mathf.Sin(_randomAngle) * _spawnDistance;

            // Add random offsets within the specified range.
            spawnX += Random.Range(-_offsetX, _offsetX);
            spawnY += Random.Range(-_offsetY, _offsetY);

            // Assign the calculated position to a Vector2 object.
            position = new Vector2(spawnX, spawnY);

        } while (IsInsideCameraView(position));

        // Return the spawn position.
        return position;
    }

    bool IsInsideCameraView(Vector2 position)
    {
        Vector3 cameraViewportPosition = _camera.WorldToViewportPoint(position);

        // Check if the position is within the camera's view.
        return (cameraViewportPosition.x >= 0f && cameraViewportPosition.x <= 1f
                && cameraViewportPosition.y >= 0f && cameraViewportPosition.y <= 1f);
    }
}
