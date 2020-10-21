using System;
class Subjects
{
    public Subjects()
    {

    }
    public Subjects(string _subject, int _score)
    {
        this._score = _score;
        this._subject = _subject;
    }
    string _subject;
    int _score;
    public string Subject{
        get{return _subject;}
        set{_subject = value;}
    }
    public int Score{
        get{return _score;}
        set{_score = value;}
    }
    public string Status()
    {
        if(_score >= 10) return "Đỗ";
        else return "Tạch";
    }

}