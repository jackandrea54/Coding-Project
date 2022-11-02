package sort;

import java.util.Random;


public class QuickSort {

    public int integerArray[] = {1,2,10,4,5,5};

    /**
     * Display an array
     */
    public void display() {
        System.out.print("[");
        for (int i = 0; i < integerArray.length; i++) {
            if (i != integerArray.length - 1) {
                System.out.print(integerArray[i] + ", ");
            } else {
                System.out.print(integerArray[i] + "]");
            }
        }
    }

    /**
     * Generate an integer randomly number
     *
     * @param size array size
     */
    public void generate(int size) {
        Random random = new Random();
        integerArray = new int[size];
        for (int i = 0; i < size; i++) {
            integerArray[i] = random.nextInt(size);
        }
    }

    int partition(int left, int right) {
        int i = left, j = right;
        int tmp;
        int pivot = integerArray[(left + right) / 2];

        while (i <= j) {
//            display();
//            System.out.println("");
            while (integerArray[i] < pivot) {
//                System.out.println("i: " + integerArray[i] + " pivot:" + pivot + " j: " + integerArray[j]);
                i++;
            }
            while (integerArray[j] > pivot) {
                j--;
            }
//            System.out.print("/i: " + integerArray[i] + " pivot:" + pivot + " j: " + integerArray[j]);
            if (i <= j) {
                tmp = integerArray[i];
                integerArray[i] = integerArray[j];
                integerArray[j] = tmp;
                i++;
                j--;
            }
//            System.out.println("");
//            display();
//            System.out.println("");
        };
//        System.out.println("\ni: " + i);
//        System.out.println("\n----");
        return i;
    }

    /*
     * Sort the array by quick sort
     */
    /* Giải thuật: Chia dãy thành 2 phần, một phần "lớn" và một phần "nhỏ".
                Chọn một khóa pivot
                Những phần tử lớn hơn pivot chia vào phần lớn
                Những phần tử nhỏ hơn hoặc bằng pivot chia vào phần nhỏ.
                Gọi đệ quy để sắp xếp 2 phần.
       Ưu điểm: chạy nhanh
       Nhược điểm: tùy thuộc vào cách chia thành 2 phần mà có thể gặp trường
       hợp xấu nhất/ tốt nhất. Không ổn định
       Time Complexities: Best: Ω(n log(n)),  Worst: O(n^2)
     */
    public void sort(int left, int right) {
        int index = partition(left, right);
        if (left < index - 1) {
            sort(left, index - 1);
        }
        if (index < right) {
            sort(index, right);
        }
    }
}