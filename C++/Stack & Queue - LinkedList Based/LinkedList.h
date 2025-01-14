#pragma once
#include <iostream>
using namespace std;

#include "Node.h"

class LinkedList
{
private:
	Node* Head, * Tail;

public:
	int Length;

public:
	LinkedList() {
		Head = Tail = NULL;
		Length = 0;
	}

	void Add(int data) {
		//Node node(data);	//This Object will die at the end of the Func.
		Node* node = new Node(data);
		if (Head == NULL) {
			Head = Tail = node;
		}
		else {
			Tail->Next = node;
			node->Prev = Tail;
			Tail = node;
		}
		Length++;
	}
	void Display() {
		Node* current = Head;
		while (current != NULL) {
			cout << current->Data << " -> ";
			current = current->Next;
		}
		cout << endl;
	}
	void Remove(int data) {
		Node* targetNode = GetNodeByData(data);

		if (targetNode == NULL) return;

		if (targetNode == Head) {
			if (targetNode == Tail) {
				Head = Tail = NULL;
			}
			else {
				Head = Head->Next;
				Head->Prev = NULL;
			}
		}
		else if (targetNode == Tail) {
			Tail = Tail->Prev;
			Tail->Next = NULL;
		}
		else {
			targetNode->Prev->Next = targetNode->Next;
			targetNode->Next->Prev = targetNode->Prev;
		}
		delete targetNode;
		Length--;
	}

	void InsertAfter(int data, int afterData) {
		Node* targetNode = GetNodeByData(data);

		if (targetNode == NULL) return;

		Node* newNode = new Node(afterData);

		if (targetNode == Tail) {
			Tail->Next = newNode;
			newNode->Prev = Tail;
			Tail = newNode;
		}
		else {

			targetNode->Next->Prev = newNode;
			newNode->Next = targetNode->Next;

			newNode->Prev = targetNode;
			targetNode->Next = newNode;
		}
		Length++;
	}
	void insertBefore(int data, int beforeData) {
		Node* targetNode = GetNodeByData(data);
		if (targetNode == NULL) return;

		Node* newNode = new Node(beforeData);

		newNode->Next = targetNode;
		if (targetNode == Head) {
			Head = newNode;
		}
		else {
			targetNode->Prev->Next = newNode;
			newNode->Prev = targetNode->Prev;
		}
		targetNode->Prev = newNode;
		Length++;
	}

	int GetDataByIndex(int index) {
		int myIndex = 0;
		Node* currentNode = Head;

		if (index < 0 || index > GetLength()) return -9999999;
		while (currentNode != NULL)
		{
			if (myIndex == index) return currentNode->Data;

			currentNode = currentNode->Next;
			myIndex++;
		}
	}


private:
	Node* GetNodeByData(int data) {
		Node* current = Head;

		while (current != NULL) {
			if (current->Data == data)
				return current;

			current = current->Next;
		}
		return NULL;
	}
	int GetLength() {
		int counter = 0;
		Node* current = Head;
		while (current != NULL) {
			counter++;

			current = current->Next;
		}
		return counter;
	}
};

