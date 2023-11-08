public class Rectangle : Shape {

    private double _eesLength;
    private double _eesWidth;
    public Rectangle(string eesColor, double eesLength, double eesWidth) : base(eesColor){
        _eesLength = eesLength;
        _eesWidth = eesWidth;
    }

    public override double GetArea()
    {
        double area = _eesLength * _eesWidth;
        return area;
    }
}
