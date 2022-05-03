using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class CameraController : MonoBehaviour
{
    public float shakeMinimumX, shakeMaximumX, shakeDuration, shakeMagnetude;
    public void Shake()
    {
        Debug.Log("teste");
        StartCoroutine(ShakeObject.Shake(shakeDuration, shakeMagnetude, shakeMinimumX, shakeMaximumX, transform));
    }
}
