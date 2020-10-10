using System;
class Scores
{
    string subject;
    int score;
    public string Subject{
        get{return subject;}
        set{subject = value;}
    }
    public int Score{
        get{return score;}
        set{score = value;}
    }
    public string Rate()
    {
        if(score >= 10) return "Đỗ";
        else return "Tạch";
    }
}