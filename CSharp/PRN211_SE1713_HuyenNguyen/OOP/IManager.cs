using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();

        public void ShowMaxList();

        public int CountPT10();

        public int GetTotalPTSlot();

        public void SortBySalary();

        public void ShowTInfo();

        public void Show3();

        public void SaveFile();
        public void LoadFile();

        /*
            -	How many parttime teachers have the slot > 10.
            -	Calculate the total number of  parttime teacher's slots.
            -	Sort the list of teachers increased by salary.
            -	Is there a teacher whose name starts with ‘T’? If so, show that person's name and salary.
            -	Displays a list of fulltime teachers with the salary coefficient < 3, in which the full name will separate First and Last Names into 2 columns.

         */
    }
}
