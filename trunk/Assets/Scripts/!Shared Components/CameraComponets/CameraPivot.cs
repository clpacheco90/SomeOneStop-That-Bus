using UnityEngine;
using System.Collections;

[System.Serializable]
public class CameraPivot {

    public Vector3 _left;
    public Vector3 _right;
    public Vector3 _center;

    public CameraPivot() {
        UpdatePivot();
    }

    public void UpdatePivot() {
        this._left   = Camera.main.ScreenToWorldPoint(Vector3.zero);
        this._right  = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, Camera.main.transform.position.y + Screen.height, 0));
        this._center = Camera.main.ScreenToWorldPoint(new Vector3((Camera.main.transform.position.x + Screen.width) * .5f, (Camera.main.transform.position.y + Screen.height) * .5f, 0));
    }

    //public static Vector3 Left() {
    //    return Camera.main.ScreenToWorldPoint(Vector3.zero);
    //}

    //public static Vector3 Right() {
    //    return Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, Camera.main.transform.position.y + Screen.height, 0));
    //}

    //public static Vector3 Center() {
    //    return Camera.main.ScreenToWorldPoint(new Vector3((Camera.main.transform.position.x + Screen.width) * .5f, (Camera.main.transform.position.y + Screen.height) * .5f, 0));
    //}

}
