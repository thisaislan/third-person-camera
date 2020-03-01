using UnityEngine;
using Axes = Metadatas.Input.Axes;

namespace Extentions
{

    public static class AxesExtention
    {
        public static float GetAxis(this Axes axes) => Input.GetAxis(axes.ToString());

        public static float GetAxisRaw(this Axes axes) => Input.GetAxisRaw(axes.ToString());

    }

}
