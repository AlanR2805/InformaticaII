public interface IBinTree{
    int Value {get;}

    IBinTree Derecho {get;}

    IBinTree Izquierdo {get;}

    int Suma();

    int[] ToArray();

    void Insert(int value);
}