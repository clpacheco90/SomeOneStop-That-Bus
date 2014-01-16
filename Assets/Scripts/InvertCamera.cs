using UnityEngine;
using System.Collections;

public class InvertCamera : MonoBehaviour {

	// EXAMPLE WITH CAMERA UPSIDEDOWN
    void OnPreCull () {
	camera.ResetWorldToCameraMatrix ();
	camera.ResetProjectionMatrix ();
	camera.projectionMatrix = camera.projectionMatrix * Matrix4x4.Scale(new Vector3 (-1, 1, 1));
    }
 
    void OnPreRender () {
	GL.SetRevertBackfacing (true);
    }
 
    void OnPostRender () {
	GL.SetRevertBackfacing (false);
    }
 
}
