#include <iostream>
using namespace std;

// ��y l� namespace dau_tien
namespace dau_tien{
   void ham(){
      cout << "B�n trong namespace dau_tien" << endl;
   }
}
// ��y l� namespace thu_hai
namespace thu_hai{
   void ham(){
      cout << "B�n trong namespace thu_hai" << endl;
   }
}


using namespace dau_tien;
int main ()
{
   // G?i h�m t? namespace dau_tien.
   ham();
   thu_hai::ham();
   return 0;
}
