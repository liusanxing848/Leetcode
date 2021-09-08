//暴力法----------------------------------------------------------------------------------------------
class Solution 
{
public:
    vector<int> twoSum(vector<int>& nums, int target) //返回值为vector，所以要用vector来承载答案
    {
        vector<int> ans;//新建vector
        for (int i = 0; i < nums.size(); i++) 
        {
            for (int j = i + 1; j < nums.size(); j++) 
            {
                if (nums[i] + nums[j] == target) {
                    ans.push_back(i);//利用vector的特性 .pushback(value)
                    ans.push_back(j);
                }
            }
        }
        
        return ans;
    }
};
//—————————————————————————————————————————————————————————————————————————————————————————————————
