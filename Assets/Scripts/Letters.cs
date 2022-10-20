using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var letterA = new Letter('A', 1);
        var letterB = new Letter('B', 3);
        var letterC = new Letter('c', 4);
        var letterD = new Letter('d', 2);
        var letterE = new Letter('e', 1);
        var letterF = new Letter('f', 4);
        var letterG = new Letter('g', 2);
        var letterH = new Letter('h', 3);
        var letterI = new Letter('i', 1);
        var letterJ = new Letter('j', 8);
        var letterK = new Letter('k', 6);
        var letterL = new Letter('l', 1);
        var letterM = new Letter('m', 4);
        var letterN = new Letter('n', 1);
        var letterO = new Letter('o', 1);
        var letterP = new Letter('p', 3);
        var letterQ = new Letter('q', 9);
        var letterR = new Letter('r', 1);
        var letterS = new Letter('s', 1);
        var letterT = new Letter('t', 1);
        var letterU = new Letter('u', 2);
        var letterV = new Letter('v', 6);
        var letterW = new Letter('w', 5);
        var letterX = new Letter('x', 7);
        var letterY = new Letter('y', 5);
        var letterZ = new Letter('z', 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Letter
{
    char letter;
    int value;

    public Letter(char letter, int value)
    {
        this.letter = letter;
        this.value = value;
    }

    char returnLetter(Letter l)
    {
        return l.letter;
    }

    int returnValue(Letter l)
    {
        return l.value;
    }
}

class Deck
{
    const int MAX_DECK_SIZE = 20;
    
    int size;
    Letter[] letters;
    
    public Deck()
    {
        size = 0;
        letters = new Letter[MAX_DECK_SIZE];
    }
    
    void addToDeck(Letter l)
    {
        if (size == MAX_DECK_SIZE)
        {
            Console.WriteLine("Deck is full. Cannot add more letters.");
        }
        else
        {
            letters[size] = l;
            size++;
        }
    }
    
    void removeLetter(Letter l)
    {
        bool letterFound = false;
        int index = -1;
        for (int i = 0; i < size; i++)
        {
            if (letters[i] == l)
            {
                index = i;
                letterFound = true;
            }
        }
        
        if (letterFound)
        {
            for (int i = index; i < size; i++)
            {
                letters[i] = letters[i+1];
            }
        }
        else
        {
            Console.WriteLine("Letter", l, "not found in deck.");
        }
    }
}