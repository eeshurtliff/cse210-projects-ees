using System;

class Reference {
    private string _khreference;
    public Reference(string khScriptureReference) {
        _khreference = khScriptureReference;
    }

    public string khReferenceToString() {
        return _khreference;
    }
}