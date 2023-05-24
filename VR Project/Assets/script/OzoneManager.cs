using UnityEngine;
using System.Collections.Generic;

public class OzoneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ozonePrefab;

    private List<GameObject> ozoneObjects;

    [SerializeField]
    private float spawnRadius = 8f;
    [SerializeField]
    private float angleMax = 360f;
    [SerializeField]
    private int numZones = 8;

    [SerializeField]
    private int numObjects = 1;
    [SerializeField]
    private int maxObjects = 6;

    private List<int> zoneIndices;
    private int currentIndex;

    private float spawnTimer = 0f;
    [SerializeField]
    private float spawnCycle = 0.8f;

    private void Awake()
    {
        ozoneObjects = new List<GameObject>();
        zoneIndices = new List<int>();
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnCycle)
        {
            spawnTimer = 0;
            if (SpawnObjects() == false)
            {
                RespawnObject();
            }
        }
    }

    private bool SpawnObjects()
    {
        bool spawnFlag = false;
        if (currentIndex == 0)
        {
            // Create a list of zone indices
            for (int i = 0; i < numZones; i++)
            {
                zoneIndices.Add(i);
            }

            // Shuffle the zone indices
            Shuffle(zoneIndices);
        }

        for (int i = 0; i < numObjects; i++)
        {
            if (ozoneObjects.Count >= maxObjects)
            {
                return spawnFlag;
            }

            Vector3 spawnPosition = NewSpawnPosition();

            // Instantiate the object prefab at the spawn position
            GameObject newGameObject = Instantiate(ozonePrefab, spawnPosition, Quaternion.identity);
            ozoneObjects.Add(newGameObject);
            newGameObject.GetComponent<Ozone>().MoveObject();
        }

        if (currentIndex >= numZones)
        {
            currentIndex = 0;
        }

        spawnFlag = true;
        return spawnFlag;
    }

    private void RespawnObject()
    {
        if (currentIndex == 0)
        {
            // Create a list of zone indices
            for (int i = 0; i < numZones; i++)
            {
                zoneIndices.Add(i);
            }

            // Shuffle the zone indices
            Shuffle(zoneIndices);
        }

        //TODO: 여러개 생성하도록 처리
        for (int i = 0; i < ozoneObjects.Count; i++)
        {
            if (ozoneObjects[i].activeSelf == false)
            {
                Vector3 spawnPosition = NewSpawnPosition();

                ozoneObjects[i].transform.position = spawnPosition;
                ozoneObjects[i].SetActive(true);
                ozoneObjects[i].GetComponent<Ozone>().MoveObject();
                break;
            }
        }


        if (currentIndex >= numZones)
        {
            currentIndex = 0;
        }
    }

    private Vector3 NewSpawnPosition()
    {
        Vector3 centerPoint = transform.position;

        // Get the zone index from the shuffled list
        int zoneIndex = zoneIndices[currentIndex % numZones];
        currentIndex++;

        // Calculate the angle range for each zone
        float angleRange = angleMax / numZones;

        // Calculate the start and end angles for the selected zone
        float startAngle = zoneIndex * angleRange;
        float endAngle = (zoneIndex + 1) * angleRange;

        // Calculate a random angle within the selected zone
        float angle = Random.Range(startAngle, endAngle) * Mathf.Deg2Rad;

        // Calculate the position within the spawn radius
        float x = centerPoint.x + Mathf.Cos(angle) * spawnRadius;
        float z = centerPoint.z + Mathf.Sin(angle) * spawnRadius;

        Vector3 spawnPosition = new Vector3(x, centerPoint.y, z);

        return spawnPosition;
    }

    // Shuffles a list using the Fisher-Yates algorithm
    private void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
