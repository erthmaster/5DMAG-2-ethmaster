using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStat : MonoBehaviour
{
    //����� ��� ������ ����������
    public int waves;
    public int allCoins;
    public int killedZombie;
    public float allTime;
    public int allUpdates;
    public int allDistance;
    public int allHits;
    public int allNoMissedHits;
    public int allCritycalHits;

    public TMP_Text text;

    public PlayerStat pStat;

    private void Start()
    {
        pStat.stat = gameObject.GetComponent<GameStat>();
        StartCoroutine("Seconds");
    }
    public void SetDef()
    {
        waves = 0;
        allCoins = 0;
        killedZombie = 0;
        allTime = 0;
        allUpdates = 0;
        allDistance = 0;
        allHits = 0;
        allNoMissedHits = 0;
        allCritycalHits = 0;
    }
    public void SetStat()
    {
        text.text = $"�� ������ {waves} ����\r\n" +
            $"�� ������ {allCoins} �����\r\n" +
            $"�� ���� {killedZombie} �����\r\n" +
            $"�� ����� {allTime/60} ������ � ��\r\n" +
            $"�� ������ {allUpdates} ���������\r\n" +
            $"�� ����� {allDistance} �����\r\n" +
            $"�� ������ ����� {allHits} ����\r\n" +
            $"� ��� ����� {allNoMissedHits} ����\r\n" +
            $"� ��� ����� {allCritycalHits} ����";
    }
    IEnumerator Seconds()
    {
        yield return new WaitForSeconds(1);
        allTime++;
        StartCoroutine("Seconds");
    }
}
