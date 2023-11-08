public class Circle : Shape {
    private double _eesRadius;
    public Circle(string eesColor, double eesRadius) : base(eesColor){
        _eesRadius = eesRadius;
    }

    public override double GetArea()
    {
        double area = 3.141592 * _eesRadius * _eesRadius;
        return area;
    }
}
