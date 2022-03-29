using System.Collections;
using UnityEngine;

public class SmoothResize : MonoBehaviour
{
    [SerializeField] private Vector3 SizeTo;
    [SerializeField] private float Duration = 1f;

    private void OnValidate()
    {
        if (Duration <= 0)
            Duration = default;
    }

    [ContextMenu(nameof(Resize))]
    public void Resize()
    {
        StartCoroutine(ResizeCoroutine());
    }
    
    private IEnumerator ResizeCoroutine()
    {
        float progress = default;
        float expiredSecond = default;
        var startPosition = transform.localScale;
        
        while (progress < 1f)
        {
            expiredSecond += Time.deltaTime;
            progress = expiredSecond / Duration;
            
            transform.localScale = Vector3.Lerp(startPosition, SizeTo, progress);
            yield return null;
        }
    }
}
