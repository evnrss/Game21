using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap77 : MonoBehaviour
{
    private Terrain terrain;

    void Start()
    {
        // �������� ������ �� terrain
        terrain = Terrain.activeTerrain;

        if (terrain == null)
        {
            Debug.LogError("Terrain not found. Make sure there is an active terrain in the scene.");
        }
        else
        {
            AlignToTerrain();
        }
    }

    void AlignToTerrain()
    {
        // �������� ������� ������� �������
        Vector3 currentPosition = transform.position;

        // ���������� ������ terrain � ����� ������� ������� �������
        float terrainHeight = terrain.SampleHeight(currentPosition);

        // ������������ ������� ������� ���, ����� �� ��� �� ����������� terrain
        currentPosition.y = terrainHeight;

        // ������������� ����� ������� �������
        transform.position = currentPosition;
    }
}

