#pragma once
#include <iostream>
using namespace std;

class Stack
{
public:
	int* arr;
	int top, size;

	Stack(int size) {
		arr = new int[size];
		this->size = size;
		top = -1;
	}

	void Push(int data) {
		if (IsFull()) return;
		top++;
		arr[top] = data;
	}
	int Pop(int& num) {
		if (IsEmpty()) return 0;

		num = arr[top];
		top--;
		return 1;
	}
	int Peek() {
		if (IsEmpty()) {
			cout << "Stack is Empty\n";
			return -9999999;
		}
		return arr[top];
	}

private:
	bool IsFull() {
		return top == size - 1;
	}
	bool IsEmpty() {
		return top == -1;
	}
};

