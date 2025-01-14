#include <iostream>
using namespace std;

#include "LinkedList.h"



int main() {
	LinkedList myList;

	myList.Add(3);
	myList.Add(5);
	myList.Add(7);
	myList.Add(9);
	myList.Add(11);

	myList.Display();

	myList.InsertAfter(9, 130);
	myList.Display();
	myList.InsertAfter(3, 435);
	myList.Display();
	myList.InsertAfter(11, 40);
	myList.Display();
	myList.InsertAfter(40, 50);
	myList.Display();

	cout << "The Data at Index 0: " << myList.GetDataByIndex(0) << endl;
	cout << "The Data at Index 1: " << myList.GetDataByIndex(1) << endl;
	cout << "The Data at Index 4: " << myList.GetDataByIndex(4) << endl;
	cout << "The Data at Index 8: " << myList.GetDataByIndex(8) << endl;
	cout << "The Data at Index -1: " << myList.GetDataByIndex(-1) << endl;
	cout << "The Data at Index 12: " << myList.GetDataByIndex(12) << endl;

	myList.Remove(7);
	myList.Remove(11);
	myList.Display();


	return 0;
}