using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class batyt : RUN
// RUN - ���������� ������, � ��� �� � �������������� ������������ � ����������
{
    new public void Update()
    {
        RUN rUN = new RUN();
        if (rUN.ToJump == true)
        {
            rUN.JunpForce = 350;
        }
        else
        {
            rUN.JunpForce = 200;
        }
    }
}
