//using System;
class program {
    public static void Main(string[] args) { 
    yiqibang fg = new yiqibang();
    fg.HelpPoint = 100;
    fg.agree();
    fg.disagree();
    }

}
abstract class Yiqibang {
    public int HelpPoint;
    public abstract void agree();
    public abstract void disagree();
}
class yiqibang : Yiqibang { 

    public override void agree() {
        Console.WriteLine(++HelpPoint);
    }
    public override void disagree(){
        Console.WriteLine(--HelpPoint);
    }
}

//interface Agree {
//    void agree();

//}
//interface Disagree {
//    void disagree();
//}