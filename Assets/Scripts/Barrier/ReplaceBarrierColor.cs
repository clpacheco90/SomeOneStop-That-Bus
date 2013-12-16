using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReplaceBarrierColor : ReplaceBarrier {

    private Uni2DSprite _sprite;
    public List<Color> _colors;
    private Color _previousColor;
    private Color _currentColor;
    private int _count;
    private int _i = 0;
	// Use this for initialization
	void Start () {
        _sprite       = gameObject.GetComponent<Uni2DSprite>();
        _currentColor = _colors[_i];
        _count        = _colors.Count;
	}
	
	// Update is called once per frame
	void Update () {
        if (_instance == ReplaceBarrier.Instance.New) {
            _currentColor = _colors.Rand(_previousColor);
            _sprite.VertexColor = _currentColor;
        }

        base.Update();
	}    
}
public static class StringExtension {
    public static Color Rand(this List<Color> listRandom, Color previousColor) {
        if (listRandom.Count <= 0) Debug.Break();
        return listRandom[new System.Random().Next(0, listRandom.Count - 1)];
    }
}
