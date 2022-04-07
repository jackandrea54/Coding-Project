#include <iostream>
using namespace std;

int main(){
	int N;
	cout << "Nhap N: ";
	cin >> N;
	for(int doc=0;doc<=2*N;doc++){
		for(int ngang=0;ngang<=2*N;ngang++){
			if(doc==N){
				cout << "* ";
			}
			else if(ngang==N || ngang == N+doc || ngang == N-doc || ngang == doc-N || ngang == 2*N-(doc-N) ){
				cout << "* ";
			}			
			else if(ngang < N+doc && ngang > N-doc && doc < N){
				cout << "  ";
			}
			else if(ngang < 2*N-(doc-N) && ngang > doc-N && doc > N){
				cout << "  ";\
			}
			else{
				cout << ". ";
			}
		}
		cout << "\n";
		
	}
	return 0;
}
