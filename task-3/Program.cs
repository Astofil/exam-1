int N=Convert.ToInt32(Console.ReadLine());
int p;
int[] array=new int[N];
for(int i=0;i<N;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<N;i++){
    p=array[i];
    array[i]=array[i+1];
    array[i+1]=p;
}
foreach(var a in array){
    Console.Write(a);
}