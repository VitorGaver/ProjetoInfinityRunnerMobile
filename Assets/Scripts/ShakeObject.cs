using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ShakeObject
{
    public static IEnumerator Shake(float duration, float magnetude, float minimumX, float maximumX, Transform transform)
    {
        Vector3 originalPos = transform.position;

        float elapse = 0.0f;

        while (elapse < duration)
        {
            float x = Random.Range(minimumX, maximumX) * magnetude;

            transform.position = new Vector3(x, originalPos.y, originalPos.z);

            elapse += Time.deltaTime;

            yield return null;
        }

        transform.position = originalPos;
    }
}
