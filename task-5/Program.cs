int N=Convert.ToInt32(Console.ReadLine());
int min,max,mn=0,mx=0;
int[] array= new int[N];
for(int i=0;i<N;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
}
min=max=array[0];
for(int i=1;i<N;i++){
    if(min>array[i]){
        min=array[i];
        mn=i;
    }
    else{
        if(max<array[i]){
            max=array[i];
            mx=i;
        }
    }
}
for(int j=mn;j<=mx;j++){
    Console.WriteLine(array[j]);
}