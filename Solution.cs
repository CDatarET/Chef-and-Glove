using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    int l = int.Parse(Console.ReadLine());
		    int[] f = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		    int[] g = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		    bool front = true;
		    bool back = true;
		    
		    for(int i = 0; i < l; i++){
		        if(f[i] > g[i]){
		            front = false;
		            break;
		        }
		    }
		    
		    int j = 0;
		    for(int i = l - 1; i >= 0; i--){
		        if(f[j] > g[i]){
		            back = false;
		            break;
		        }
		        j++;
		    }
		    
		    if(front && back){
		        Console.WriteLine("both");
		    }
		    else{
		        if(front){
		            Console.WriteLine("front");
		        }
		        if(back){
		            Console.WriteLine("back");
		        }
		        if(!front && !back){
		            Console.WriteLine("none");
		        }
		    }
		    
		}
	}
}
