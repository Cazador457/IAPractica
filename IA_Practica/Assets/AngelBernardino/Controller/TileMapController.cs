using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapController : MonoBehaviour
{
    public Vector2Int[] mapSize;
    public Vector2Int[] mapOrigin;
    public Tile[] tiles;

    //Mapas tienen que ser de 30 x 15

    private void Start()
    {
        //1. crear un objeto vacio
        GameObject grid = new GameObject();
        grid.name = "Grid";

        //2. Asignarle un componente Grid (un objeto Grid)
        grid.AddComponent<Grid>();


        //2.1. agregar un CellLayout y un CellSize especifico
        Grid isogrid = grid.GetComponent<Grid>();
        isogrid.cellLayout = GridLayout.CellLayout.Rectangle;
        isogrid.cellSize = new Vector3(1f, 1f, 1); //Aqui se define el tamaño de las celdas por pixel contando a 1 como 100

        //3.Crear un nuevo objeto tipo TileMap
        GameObject tilemap = new GameObject();
        tilemap.name = "TileMap";


        //4.Asignarle un componente TileMap y TilemapRenderer
        tilemap.AddComponent<Tilemap>();
        tilemap.AddComponent<TilemapRenderer>();

        //4.1
        TilemapRenderer TopR = tilemap.GetComponent<TilemapRenderer>();
        TopR.sortOrder = TilemapRenderer.SortOrder.TopRight;

        //5.Asignarle a tilemap el padre grid
        tilemap.transform.parent = grid.transform;

        Tilemap maptile = tilemap.GetComponent<Tilemap>();
        /*Rectangle00(map);
        Rectangle01(map);
        Rectangle02(map);
        Line00(map);
        Triangle00(map);*/
        Rectangle(maptile, tiles[0], mapOrigin[0], mapSize[0]);
        Rectangle(maptile, tiles[1], mapOrigin[1], mapSize[1]);
        Rectangle(maptile, tiles[2], mapOrigin[2], mapSize[2]);
        Rectangle(maptile, tiles[3], mapOrigin[3], mapSize[3]);
        Rectangle(maptile, tiles[4], mapOrigin[4], mapSize[4]);
        Rectangle(maptile, tiles[5], mapOrigin[5], mapSize[5]);
        Triangle(maptile, tiles[6], mapOrigin[6], mapSize[6]);
        Triangle(maptile, tiles[7], mapOrigin[7], mapSize[7]);

        Rectangle(maptile, tiles[8], mapOrigin[8], mapSize[8]);
        Rectangle(maptile, tiles[9], mapOrigin[9], mapSize[9]);
        Rectangle(maptile, tiles[10], mapOrigin[10], mapSize[10]);
        Rectangle(maptile, tiles[11], mapOrigin[11], mapSize[11]);
        Rectangle(maptile, tiles[12], mapOrigin[12], mapSize[12]);
        Rectangle(maptile, tiles[13], mapOrigin[13], mapSize[13]);
        Triangle(maptile, tiles[14], mapOrigin[14], mapSize[14]);
        Triangle(maptile, tiles[15], mapOrigin[15], mapSize[15]);
        Rectangle(maptile, tiles[16], mapOrigin[16], mapSize[16]);
        Triangle(maptile, tiles[17], mapOrigin[17], mapSize[17]);
        Rectangle(maptile, tiles[18], mapOrigin[18], mapSize[18]);
        Triangle(maptile, tiles[19], mapOrigin[19], mapSize[19]);
        Rectangle(maptile, tiles[20], mapOrigin[20], mapSize[20]);

        Rectangle(maptile, tiles[21], mapOrigin[21], mapSize[21]);
        Rectangle(maptile, tiles[22], mapOrigin[22], mapSize[22]);
        Rectangle(maptile, tiles[23], mapOrigin[23], mapSize[23]);
        Rectangle(maptile, tiles[24], mapOrigin[24], mapSize[24]);
        Rectangle(maptile, tiles[25], mapOrigin[25], mapSize[25]);
        Rectangle(maptile, tiles[26], mapOrigin[26], mapSize[26]);
        Rectangle(maptile, tiles[27], mapOrigin[27], mapSize[27]);

        Triangle(maptile, tiles[28], mapOrigin[28], mapSize[28]);
        Rectangle(maptile, tiles[29], mapOrigin[29], mapSize[29]);
        Rectangle(maptile, tiles[30], mapOrigin[30], mapSize[30]);
        Rectangle(maptile, tiles[31], mapOrigin[31], mapSize[31]);
        Rectangle(maptile, tiles[32], mapOrigin[32], mapSize[32]);
        Rectangle(maptile, tiles[33], mapOrigin[33], mapSize[33]);
        Rectangle(maptile, tiles[34], mapOrigin[34], mapSize[34]);
        Rectangle(maptile, tiles[35], mapOrigin[35], mapSize[35]);
        Triangle(maptile, tiles[36], mapOrigin[36], mapSize[36]);
        Rectangle(maptile, tiles[37], mapOrigin[37], mapSize[37]);
        Rectangle(maptile, tiles[38], mapOrigin[38], mapSize[38]);
        Triangle(maptile, tiles[39], mapOrigin[39], mapSize[39]);

        //Line(maptile, tiles[6], mapOrigin[6], mapSize[6]);
        //Rectangle(maptile, tiles[8], mapOrigin[8], mapSize[8]);
        //Rectangle(maptile, tiles[9], mapOrigin[9], mapSize[9]);
        //Rectangle(maptile, tiles[10], mapOrigin[10], mapSize[10]);
    }

    private void Rectangle(Tilemap tilemap, Tile tile,Vector2Int mapOrigin, Vector2Int mapSize)
    {
        Map map = new Map(mapOrigin, mapSize, tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tile);
    }
    private void Triangle(Tilemap tilemap, Tile tile, Vector2Int mapOrigin, Vector2Int mapSize)
    {
        Map map = new Map(mapOrigin, mapSize, tilemap, Map.MapType.Triangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tile);
    }
    private void Line(Tilemap tilemap, Tile tile, Vector2Int mapOrigin, Vector2Int mapSize)
    {
        Map map = new Map(mapOrigin, mapSize, tilemap, Map.MapType.Line);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tile);
    }

    /*private void Rectangle00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[0], mapSize[0], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[0]);
    }
    private void Rectangle01(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[1], mapSize[1], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[1]);
    }
    private void Rectangle02(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    private void Rectangle03(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[3], mapSize[3], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3]);
    }
    private void Rectangle04(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    private void Rectangle05(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    private void Rectangle06(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    /*private void Line00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[3], mapSize[3], tilemap, Map.MapType.Line);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3]);
    }
    private void Triangle00(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[4], mapSize[4], tilemap, Map.MapType.Triangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[4]);
    }

    /*
    private void Rectangle0(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[1], mapSize[1], tilemap, Map.MapType.Rectangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[1]);

    }
    private void Triangle(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[3], mapSize[3], tilemap, Map.MapType.Triangle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3]);
    }
    private void Line(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[0], mapSize[0], tilemap, Map.MapType.Line);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[0]);
    }
    private void Circle(Tilemap tilemap)
    {
        Map map = new Map(mapOrigin[2], mapSize[2], tilemap, Map.MapType.Circle);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2]);
    }
    */
}
