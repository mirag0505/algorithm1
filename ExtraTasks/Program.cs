using AlgorithmsDataStructures;

namespace ExtraTask
{
    public class CustomFunctions
    {
        public static LinkedList SumMatchingElementsInEqualLists(LinkedList _list1, LinkedList _list2)
        {
            int lengthList1 = _list1.Count();
            int lengthList2 = _list2.Count();

            LinkedList resultList = new LinkedList();

            if (lengthList1 == lengthList2)
            {
                Node node1 = _list1.head;
                Node node2 = _list2.head;

                while (node1 != null || node2 != null)
                {
                    if (node1 == null || node2 == null)
                    {
                        break;
                    }

                    resultList.AddInTail(new Node(node1.value + node2.value));

                    node1 = node1.next;
                    node2 = node2.next;
                }
            }

            return resultList;
        }
    }
}