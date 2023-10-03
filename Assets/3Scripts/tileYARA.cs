using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileYARA : MonoBehaviour
{
    private static tileYARA selected;
    private SpriteRenderer Renderer;

    public Vector2Int Position;

    private void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

    public void Select()
    {
        Renderer.color = Color.grey;
    }

    public void Unselect()
    {
        Renderer.color = Color.white;
    }

    private void OnMouseDown2()
    {
        if (selected != null)
        {
            if (selected == this)
                return;
            selected.Unselect();
            if (Vector2Int.Distance(selected.Position, Position) == 1)
            {
                yaracopy.Instance.SwapTiles2(Position, selected.Position);
                selected = null;
            }
            else
            {
                //GerenciaSom.Instance.PlaySound(SoundType.TypeSelect);
                selected = this;

                Select();
            }
        }
        else
        {
            //GerenciaSom.Instance.PlaySound(SoundType.TypeSelect);
            selected = this;
            Select();
        }
    }

}