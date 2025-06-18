using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FromPointToPointRepeatedly : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
    [SerializeField] private float time;
    [SerializeField] private List<TrailRenderer> trails;

    private void Start()
    {
        StartCoroutine(GotoRepeatedly());
    }

    private IEnumerator GotoRepeatedly()
    {
        while (true)
        {
            transform.position = start.position;
            foreach (var trail in trails)
            {
                trail.Clear();
            }
            yield return transform.DOMove(end.position, time).SetEase(Ease.Linear).WaitForCompletion();
        }
    }
}
