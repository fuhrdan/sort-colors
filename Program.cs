// Leetcode 75 solution in C
void sortColors(int* nums, int numsSize) {
    int red = 0;
    int white = 0;
    int blue = 0;
    for(int x = 0; x < numsSize; x++)
    {
        if(nums[x] == 0) red++;
        else if (nums[x] == 1) white++;
        else blue++;
    }

    int i=0;
    while(red > 0)
    {
        nums[i] = 0;
        red--;
        i++;
    }
    while(white > 0)
    {
        nums[i] = 1;
        white--;
        i++;
    }
    while(blue > 0)
    {
        nums[i] = 2;
        blue--;
        i++;
    }
}