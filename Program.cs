using CollectionDemo.cs;

namespace CollectionDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            ArrayListDemo arrayListDemo = new ArrayListDemo();
            arrayListDemo.Display();



            CollectionListDemo collectionListDemo = new CollectionListDemo();
            collectionListDemo.Display();


            CollectionStackDemo collectionStackDemo = new CollectionStackDemo();
            collectionStackDemo.Display();


            CollectionQueueDemo collectionQueueDemo = new CollectionQueueDemo();
            collectionQueueDemo.Display();
        }
    }

  
}

