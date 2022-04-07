#include <iostream>
using namespace std;

// day la namespace dau tien
namespace dau_tien{
   void ham(){
      cout << "Ben trong namespace dau_tien" << endl;
   }
   // day la namespace thu hai
   namespace thu_hai{
      void ham(){
         cout << "Ben trong namespace thu_hai" << endl;
      }
   }
}
void func(){
	dau_tien::ham();
}
using namespace dau_tien::thu_hai;

int main (){
   func();
   ham();
   return 0;
}



