public class Math
{
  public double Abs(double c)
  {
   if(c<0) return (c*-2)/2;
   else return c;
  }
  public float Abs(float b)
  {
   if(b<0) return b*-2/2;
   else return b;
  }
  public int Abs(int a)
  {
   if(a<0) return a*-2/2;
   else return a;
  }
  double s=1;
  public double Pow(double x, double y)
    {
        if(y<=0) return s;
        s*=x;
        return Pow(x,y-1);
    }
    public double Sqrt(int a)
    {
       if(a==0) return 0;
       double s= a;
       for (int i = 0; i < 100; i++)
       {
        s=(s+a/s)/2;
       }
       return s;
    }
    public int Max(int a, int b)
    {
        if(a<b) return b;
        else return a;
    }
    public int Min(int a, int b)
    {
        if(a<b) return a;
        else return b;
    }
    
}