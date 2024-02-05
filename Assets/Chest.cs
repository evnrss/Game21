using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // �������� �������
    private Animator chestAnimator;

    // ��������, ������ �� ������
    private bool isOpen = false;

    void Start()
    {
        // �������� ��������� ���������
        chestAnimator = GetComponent<Animator>();
    }

    // �������, ������� ���������� ��� ������� �� ������
    void OnMouseDown()
    {
        // ���������, ������ �� ��� ������
        if (!isOpen)
        {
            // ���� ���, �� ��������� ���
            chestAnimator.SetTrigger("OpenChest");
            isOpen = true;
        }
    }
}