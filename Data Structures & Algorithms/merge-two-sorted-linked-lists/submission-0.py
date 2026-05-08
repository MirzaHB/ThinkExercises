# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if list1==None and list2==None:
            return
        firstVal = None
        if list1 != None and list2 !=None:
            if list1.val<=list2.val:
                firstVal = list1.val
                list1 = list1.next
            else:
                firstVal = list2.val
                list2 = list2.next
        elif list1!=None and list2==None:
            firstVal = list1.val
            list1 = list1.next
        else:
            firstVal = list2.val
            list2 = list2.next

        mergedList = ListNode(firstVal)
        curr = mergedList

        while(list1!= None or list2!= None):
            
            if(list1 != None and list2 == None):
                newNode = ListNode(list1.val)
                list1 = list1.next
                curr.next = newNode
                curr = curr.next
            
            if(list2 != None and list1==None):
                newNode = ListNode(list2.val)
                list2 = list2.next
                curr.next = newNode
                curr = curr.next   

            if(list1 != None and list2 != None):
                if(list1.val <= list2.val):
                    newNode = ListNode(list1.val)
                    list1 = list1.next
                    curr.next = newNode
                    curr = curr.next
                else:
                    newNode = ListNode(list2.val)
                    list2 = list2.next
                    curr.next = newNode
                    curr = curr.next
        return mergedList