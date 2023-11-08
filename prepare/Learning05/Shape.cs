using System.ComponentModel.DataAnnotations;

public abstract class Shape {
    protected string _eesColor;



    public Shape(string eesColor){
        _eesColor = eesColor;
    }
    public string GetColor(){
        return _eesColor;
    }

    public void SetColor(string eesColor){
        _eesColor = eesColor;
    }

    public abstract double GetArea();
        
    
}