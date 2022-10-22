int N=Convert.ToInt32(Console.ReadLine());
int count=1;
int[] array=new int[N];
for(int i=0;i<N;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<N-1;i++){
    if(array[i]!=array[i+1]){
        count++;
    }
}
Console.WriteLine(count);