using System;

namespace CSharp.Activity.Datastore
{
    /// <summary>
    /// Abstract class for storage of items of type T.
    /// </summary>
    public abstract class ArrayBase<T>
    {
        /// <summary>
        /// A constant that represents the value returned when an item cannot be found in the array.
        /// </summary>
        public const int NOT_IN_STRUCTURE = -1;

        /// <summary>
        /// A constant that represents the default size of the array.
        /// </summary>
        public const int DEFAULT_SIZE = 5;

        /// <summary>
        /// This is the actual structure that the class uses to store array items.
        /// </summary>
        private T[] storeArray;

        /// <summary>
        /// The number of items currently holt in the array.
        /// </summary>
        private int currentCount = 0;


        /// <summary>
        /// Constructor which takes an integer argument and initializes the array with the input argument.
        /// </summary>
        /// <param name="arraySize">Size for which the array has to be initialized</param>
        public ArrayBase(int arraySize = DEFAULT_SIZE)
        {
            // TODO Activity 2.1 
            // Initialize the array 'storeArray' that can hold a number of items
            // specified by 'arraySize'.
            // If the value of 'arraySize' is illegal for an array, 
            // then use DEFAULT_SIZE instead.

            //start solution

            this.storeArray = new T[arraySize];

            if (arraySize < 0) 
            {
               storeArray = new T[DEFAULT_SIZE];
            }
        }
        


        /// <summary>
        /// Checks if the array is empty or not.
        /// </summary>
        /// <returns>
        /// A boolean value 'true' if the array is empty, and 'false' otherwise.
        /// </returns>
        public bool IsEmpty()
            => (this.Count <= 0); // Using expression-bodied syntax of C# 6


        /// <summary>
        /// Checks if the array is completely filled out or not.
        /// </summary>
        /// <returns>
        /// A boolean value 'true' if the array is full, and 'false' otherwise.
        /// </returns>
        public bool IsFull()
            => (this.Count == this.Capacity);
        

        /// <summary>
        /// Returns the maximum size of the array.
        /// </summary>
        public int Capacity
            => storeArray.Length;


        /// <summary>
        /// Returns the current number of items in an array.
        /// </summary>
        public int Count
        {
            get
            {
                return currentCount;
            }
            protected set
            {
                currentCount = value;
            }
        }


        /// <summary>
        /// Indexer property to return/change the value at the specified index.
        /// </summary>
        /// <param name="index">The index from which the value is required.</param>
        /// <returns>The value at the specified index.</returns>
        public virtual T this[int index]
        {
            get
            {
                if ((index < 0) || (index >= this.Capacity))
                    throw new IndexOutOfRangeException("Invalid Index");

                return storeArray[index];
            }
            protected set
            {
                storeArray[index] = value;
                
            }
        }


        /// <summary>
        /// Checks if the input argument can be found in the array.
        /// </summary>
        /// <param name="arg">The item to be checked for existence in the array</param>
        /// <returns>
        /// A boolean value 'true' if the argument can becound, and 'false' otherwise.
        /// </returns>
        public bool Contains(T arg)
            => (IndexOf(arg) != NOT_IN_STRUCTURE);


        /// <summary>
        ///      Method to check if an item is in the data structure.
        /// </summary>
        /// <param name="argToFind">The argument to be checked for existence in the array.</param>
        /// <returns>
        ///      Returns the index at which the input argument if it is found in the array,
        ///      and NOT_IN_STRUCTURE otherwise.
        /// </returns>
        public virtual int IndexOf(T argToFind)
        {
            //TODO Activity 2.2
            //Search through the current contents of the array 'storeArray' and determine if there is any item
            //in the array that is equal to 'argToFind' according to Equals() method. Return the index where that 
            //item is located or NOT_IN_STRUCTURE, if the item is not within
            //the array.
            //Loop through the array
            //HINT: All items have a method named Equals() that returns a boolean. 
            //Example: This tests if obj1 is "Equal to" obj2
            // if (obj1.Equals(obj2))
            // {
            //    :::
            // }

            //start solution

            for (int i = 0; i < storeArray.Length; i++)
            {
                if (storeArray[i].Equals(argToFind))
                    return i;
     
            }

            return NOT_IN_STRUCTURE;


            //foreach (var item in storeArray)
            //{

            //    if (item.Equals(argToFind))

            //        return IndexOf(item);

            //}

            
            
        }


        /// <summary>
        ///     Adds new item to the array.
        /// </summary>
        /// <param name="obj">The argument to add to an array.</param>
        /// <returns>Returns NOT_IN_STRUCTURE if array is full, or added item index if addition succeeded.</returns>
        public virtual int Add(T obj)
        {
            //TODO Activity 2.3
            //Add item to the array if array is not full and return new item index, otherwise return NOT_IN_STRUCTURE.

            //start solution
            if (IsFull())
                throw new IndexOutOfRangeException();

            if (currentCount >= Capacity)
                return NOT_IN_STRUCTURE;


            else
            {
                //       this[this.Count] = obj;
                //       this.Count++;


                //return this.Count;

                storeArray[currentCount++] = obj;
                return this.Count;
            }
            

           




        }

        /// <summary>
        /// Removes item from the array at the specified index.
        /// </summary>
        /// <param name="index">The index to an array.</param>
        /// <returns>Throws InvalidOperationException if removal is not possible.</returns>
        public virtual void RemoveAt(int index)
        {
            //TODO Activity 2.4
            //Remove item from the array, but if array is empty throw InvalidOperationException.
            //If the index is not last, compact remaining array items.

            //start solution

            if (IsEmpty())
            {
                throw new InvalidOperationException("Impossible to remove.");
            }
            if(index < 0 || index > Capacity)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            

            else
                storeArray[index] = storeArray[index++];
          

            
            
        }

            
          
        }
    }

