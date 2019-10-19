public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> triangle = new List<IList<int>>(numRows);
        
        if (numRows == 0) return triangle;
        
        List<int> first_row = new List<int>();
        first_row.Add(1);
        triangle.Add(first_row);

        for(int i=1; i<numRows ; i++){
            
            IList<int> prev_row = triangle[i-1];
            List<int> current_row = new List<int>();
            
            current_row.Add(1);
            
            for(int j=1; j<i; j++)
            {
                current_row.Add(prev_row[j-1]+prev_row[j]);
            }
            
            current_row.Add(1);
            triangle.Add(current_row);
        }
            
        return triangle;
        
    }
}