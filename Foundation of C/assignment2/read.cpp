#include <fstream>
#include <iostream>
#include <string>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	ifstream fs;
	fs.open ("taxCalculator2.exe", ios::binary);
	if (fs.fail()) {
		cerr << "Failed to open file!\n";
		return 1;
	}
	fs.seekg(0, ios::end);
	size_t i = fs.tellg();
	char* buf = new char[i];
	fs.seekg(0, ios::beg);
	fs.read (buf, i);
	fs.close();
	string s;
	s.assign (buf, i);
	delete [] buf;


	// access 's' std::string here
	cout << s.length() << endl;

	return 0;
}
