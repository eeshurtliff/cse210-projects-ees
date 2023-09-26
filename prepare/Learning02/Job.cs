public class EesJob {
    public string _eesCompany;
    public string _eesJobTitle;
    public int _eesStartYear;
    public int _eesEndYear;

    public void EesDisplayDetails(){
        Console.WriteLine($"{_eesJobTitle} ({_eesCompany}) {_eesStartYear}-{_eesEndYear}");
    }
}