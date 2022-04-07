#include <iostream>
using namespace std;

// Ðây là namespace dau_tien
namespace dau_tien{
   void ham(){
      cout << "Bên trong namespace dau_tien" << endl;
   }
}
// Ðây là namespace thu_hai
namespace thu_hai{
   void ham(){
      cout << "Bên trong namespace thu_hai" << endl;
   }
}


using namespace dau_tien;
int main ()
{
   // G?i hàm t? namespace dau_tien.
   ham();
   thu_hai::ham();
   return 0;
}
