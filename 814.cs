public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        int size = rooms.Count;
        int[] arr = new int[size];
        
        Stack<int> keys = new Stack<int>();
        keys.Push(0);
        
        while(keys.Count!=0){
            int current_key = keys.Pop(); 
            arr[0]=1;
            foreach (var item in rooms[current_key]){
                System.Console.WriteLine(item);
                if(arr[item]!=1){
                    arr[item]=1;
                    keys.Push(item);
                }
            }
        }
        
        foreach(var item1 in arr){
            System.Console.WriteLine(item1);
            if (item1 == 0)
                return false;
        }
        
        
        
        return true;
        
    }
}