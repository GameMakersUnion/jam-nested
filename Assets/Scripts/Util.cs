using UnityEngine;
using System.Collections;

public static class Util {

    //avoids repetition of manually breaking down to components every time
    public static void Add(Vector3 source, Vector3 addtn)
    {
        source = new Vector3(source.x + addtn.x, source.y + addtn.y, source.z + addtn.z);
    }


}
