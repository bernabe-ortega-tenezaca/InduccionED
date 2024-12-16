public class Producto{
    private int Id;
    public string Nombre { get; set; }
    public string Unidad { get; set; }

    public Producto(int _id, string _nombre, string _unidad){
        Id = _id;
        Nombre = _nombre;
        Unidad = _unidad;
    }

    public Producto(){}

}