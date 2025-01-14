#include <iostream>
using namespace std;

#include "Stack.h"

int main()
{
	Stack stack(4);

	stack.Push(50);
	stack.Push(80);
	stack.Push(20);

	int num;

	int result = stack.Pop(num);
	cout << num << "\t" << result << endl;
	result = stack.Pop(num);
	cout << num << "\t" << result << endl;
	result = stack.Pop(num);
	cout << num << "\t" << result << endl;

	result = stack.Pop(num);
	cout << num << "\t" << result << endl;

	stack.Push(333);
	result = stack.Pop(num);
	cout << num << "\t" << result << endl;
	stack.Push(111);




	return 0;
}