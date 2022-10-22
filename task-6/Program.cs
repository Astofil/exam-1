int N=Convert.ToInt32(Console.ReadLine());
int p=1,sum=1;
for(int i=1;i<=N;i++){
    for(int j=1;j<=i;j++){
        p=p*2;
    }
    
    sum=sum+p;
    Console.WriteLine(sum);
}
Console.Write(sum);