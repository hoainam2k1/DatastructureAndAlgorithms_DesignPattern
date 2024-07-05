// Có thể thực hiện theo 2 cách sau: tìm kiếm nhị phân lặp, tìm kiếm nhị phân đệ quy
using System;
public class SampleBinarySearch
{
    // Hàm lặp
    static int BinarySearch(int[] arr, int index)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            // Check if index is present at mid
            if (arr[mid] == index)
                return mid;

            // If index greater, ignore left half
            if (arr[mid] < index)
                low = mid + 1;

            // If index is smaller, ignore right half
            else
                high = mid - 1;
        }
        // If we reach here, then element was
        // not present
        return -1;
    }
    // Hàm đệ quy
    static int binarySearch(int[] arr, int low, int high, int x)
    {
        if (high >= low)
        {
            int mid = low + (high - low) / 2;

            // If the element is present at the
            // middle itself
            if (arr[mid] == x)
                return mid;

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if (arr[mid] > x)
                return binarySearch(arr, low, mid - 1, x);

            // Else the element can only be present
            // in right subarray
            return binarySearch(arr, mid + 1, high, x);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int index = 10;
        int result = BinarySearch(arr, index);
        if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at "
                              + "index " + result);
    }
}
/* Độ phức tạp về thời gian
 * - Trường hợp tốt nhất: O(1)
 * - Trường hợp xấu nhất: O(log N)
 * - Trường hợp trung bình: O(log N)
 */
/* Ưu nhược điểm
 * - Ưu: Tìm kiếm nhị phân nhanh hơn tìm kiếm tuyến tính, đặc biệt đối với các mảng lớn, hiệu quả hơn các thuật toán tìm kiếm khác có độ phức tạp về thời gian tương tự, chẳng hạn như tìm kiếm nội suy hoặc tìm kiếm theo cấp số nhân, tìm kiếm nhị phân rất phù hợp để tìm kiếm các tập dữ liệu lớn được lưu trữ trong bộ nhớ ngoài, chẳng hạn như trên ổ cứng hoặc trên đám mây
 * - Nhược: mảng nên được sắp xếp, tìm kiếm nhị phân yêu cầu cấu trúc dữ liệu đang được tìm kiếm phải được lưu trữ ở các vị trí bộ nhớ liền kề, yêu cầu các phần tử của mảng phải có thể so sánh được, nghĩa là chúng phải có thứ tự
 */