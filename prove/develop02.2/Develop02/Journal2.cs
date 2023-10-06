public class EesJournal{
    public List<EesEntry> _eesEntry = new List<EesEntry>();

    public void DisplayJournal(){
        // for (int i = 0; i < _eesEntry.Count; i++){
        //     Console.WriteLine(_eesEntry[i]);
        //     Console.WriteLine();
        // }
        foreach (EesEntry eesSingleEntry in _eesEntry){
            eesSingleEntry.EesDisplayCompleteEntry();
        }
    }

    
}