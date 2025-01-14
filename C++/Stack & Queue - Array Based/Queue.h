#pragma once
#include <iostream>
using namespace std;

class Queue
{
public:
	int* arr;
	int size, front, back;

	Queue(int size) {
		arr = new int[size];
		this->size = size;
		front = back = -1;
	}
	void Enqueue(int data) {
		if (IsFull()) return;

		if (IsEmpty()) front++;
		back++;
		arr[back] = data;
	}
	int Dequeue(int& data) {
		if (IsEmpty()) return 0;

		data = arr[front];
		Shift();

		return 1;
	}

private:
	bool IsFull() {
		return back == size - 1;
	}
	bool IsEmpty() {
		return front == -1;
	}
	void Shift() {
		for (int i = front; i < back; i++) {
			arr[i] = arr[i + 1];
		}
		back--;

		if (front == back == 0) {
			front = back = -1;
		}
	}
};

