public class Square : Shape{

    private double _eesSide;
    public Square(string eesColor, double eesSide) : base(eesColor){
        _eesSide = eesSide;
    }

    public override double GetArea()
    {
        double area = _eesSide * _eesSide;
        return area;
    }
}