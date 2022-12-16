﻿using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /*Initializing the values of the variabels REAR and FRONT to -1 to indicate that the queue is initially empty. */
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /* The following statement checks whether the queue is empty. If the queue is empty, then the value of the REAR and FRONT variable is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* If REAR is at the last position of the array, then the value of REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*If REAR is not at the last position, then its value is incremend by one.  */
                    REAR = REAR + 1;
            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;

        }
        public void remove()
        {
            /* Checks whether the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");
            /* Checks if the queue has one element */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }
    }
}