using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCreator : MonoBehaviour
{
    public GameObject playerPrefab;
    public Terrain terrain;
    public GameObject treePrefab;
    public Camera mainCamera;

    private void Start()
    {
        // Create terrain
        terrain = Terrain.CreateTerrainGameObject(new TerrainData()).GetComponent<Terrain>();

        // Place player
        Instantiate(playerPrefab, new Vector3(0, terrain.SampleHeight(Vector3.zero) + 1, 0), Quaternion.identity);

        // Add trees
        for (int i = 0; i < 20; i++)
        {
            Vector3 treePosition = new Vector3(Random.Range(-50f, 50f), terrain.SampleHeight(Vector3.zero), Random.Range(-50f, 50f));
            Instantiate(treePrefab, treePosition, Quaternion.identity);
        }

        // Set camera position and rotation
        mainCamera.transform.position = new Vector3(0, 10, -10);
        mainCamera.transform.rotation = Quaternion.Euler(45, 0, 0);
    }
}
