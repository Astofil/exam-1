public class Minimum{
    public int a;
    public int b;
    public int c;
    public int d;

    public int FindMinimum()
    {
        int min=a;
        if(min>b){
            min=b;
        }
        if(min>c){
            min=c;
        }
        if(min>d){
            min=d;
        }
        return min;
    }
}