
using System.Linq;

public class BinaryTree : IBinTree{
    public int Value {get;}

    public IBinTree Derecho { get; set; }

    public IBinTree Izquierdo { get; set; }

    public BinaryTree(int v, IBinTree der, IBinTree izq){
        this.Value = v;
        this.Derecho = der;
        this.Izquierdo = izq;
    }

    public BinaryTree(int valor){
        this.Value = valor;
    }

    public override string ToString(){
        string der = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izq = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();

        return $"{this.Value} \n\t {der} \n\t {izq}";
    }

    public int Suma()
    {
        int sumaIzquierda = this.Izquierdo == null ? 0 : this.Izquierdo.Suma();
        int sumaDerecha = this.Derecho == null ? 0 : this.Derecho.Suma();

        return sumaDerecha + sumaIzquierda + this.Value;
    }

    public int[] ToArray()
    {
        var temp = new int[0];
        int[] resultado = new int[0];
        if (this.Izquierdo != null)
        {
            var izqArr = Izquierdo.ToArray();
            resultado = izqArr;
        }

        temp = new int[resultado.Length + 1];
        resultado.CopyTo(temp, 0);
        var valArr = new int[] { this.Value };
        valArr.CopyTo(temp, resultado.Length);
        resultado = temp;

        if (this.Derecho != null)
        {
            var derArr = Derecho.ToArray();
            temp = new int[derArr.Length + resultado.Length];
            resultado.CopyTo(temp, 0);
            derArr.CopyTo(temp, resultado.Length);
        }

        resultado = temp;

        return resultado;
    }

    public void Insert(int valor)
    {
        if (valor <= this.Value)
        {
            if (Izquierdo == null)
            {
                this.Izquierdo = new BinaryTree(valor);
            } else
            {
                Izquierdo.Insert(valor);
            }
        } else
        {
            if (Derecho == null)
                this.Derecho = new BinaryTree(valor);
            else
                Derecho.Insert(valor);
        }
    }
}