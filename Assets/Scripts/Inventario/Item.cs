using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{

    [Header("Gameplay")]
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("UI")]
    public Sprite image;
    public bool stackable = true; //por si hay q acumular objetos

    
}

public enum ItemType
{
    Objeto,
    Arma
}

public enum ActionType //estos son ejempñlos
{
    Disparar,
    Cortar
}
