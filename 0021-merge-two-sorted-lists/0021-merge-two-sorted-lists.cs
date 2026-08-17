
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode nodAnchor = new ListNode(0);
    ListNode nodBuild = nodAnchor;

        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                nodBuild.next = list1;
                list1 = list1.next;
            }
            else
            {
            nodBuild.next = list2;
                list2 = list2.next; 
            }
            nodBuild = nodBuild.next;
        }
        if (list1 != null)
        {
            nodBuild.next = list1;
        }
        else
        {
            nodBuild.next = list2;
        }
        return nodAnchor.next;
    }
}