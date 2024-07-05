using System;
public class SamplerLinearSearch
{
    public static int search(int[] arr, int length, int index)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == index)
                return i;
        }
        return -1;
    }
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int index = 10;

        int result = search(arr, arr.Length, index);
        if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at index "
                              + result);
    }
}

/* Độ phức tạp về thời gian
 * - Trường hợp tốt nhất: khóa có thể ở chỉ mục đầu tiên O(1)
 * - Trường hợp xấu nhất: khóa ở mục cuối cùng O(N)
 * - Trường hợp trung bình: O(N)
 */
/* Ưu nhược điểm
 * - Ưu: có thể sử dụng bất kể mảng đã được sắp xếp hay chưa, có thể sử dụng trên mảng thuộc bất kì loại dữ liệu nào, không yêu cầu bất kì bộ nhớ bổ sung, phù hợp cho các tập dữ liệu nhỏ
 * - Nhược: có độ phức tạp về thời gian là O(N) do đó làm cho nó chậm đối với các tập dữ liệu lớn, không phù hợp với mảng lớn
 */