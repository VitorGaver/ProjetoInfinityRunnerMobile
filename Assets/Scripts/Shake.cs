using System.Collections;
using UnityEngine;

class Shake
{
    public Transform transform;
    public float duration, magnetude, minimalPosition, maximumPosition;

    IEnumerator ShakeObject()
    {
        Vector3 originalPos = transform.position;

        float elapse = 0.0f;

        while (elapse < duration)
        {
            float x = Random.Range(minimalPosition, maximumPosition) * magnetude;

            transform.position = new Vector3(x, originalPos.y, originalPos.z);

            elapse += Time.deltaTime;

            yield return null;
        }

        transform.position = originalPos;
    }
}