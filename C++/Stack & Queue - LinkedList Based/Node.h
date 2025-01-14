#pragma once
#include <iostream>
using namespace std;


class Node
{
public:

	int Data;
	Node* Next, * Prev;

	Node(int data) {
		Data = data;
		Next = Prev = NULL;
	}
};