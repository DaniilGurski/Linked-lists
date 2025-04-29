class SingleLinkedList<T> {
    Node<T>? head;
    public SingleLinkedList() {
        head = null;
    }

    // Add first node
    public void addFirst(T data) {
        if (head == null) {
            head = new Node<T>(data);
            return;
        }

        Node<T> new_node = new Node<T>(data, head);
        head = new_node;
    }

    public void addLast(T data) {
        if (head == null) {
            head = new Node<T>(data);
            return;
        }

        Node<T>? temp = head;
        while (temp.Next != null) {
            temp = temp.Next;
        }

        temp.Next = new Node<T>(data);
    }

    public void addNodeInPosition(T data, int position) {
        if (position == 0) {
            addFirst(data);
            return;
        }

        Node<T>? temp = head;
        // Add node in postion if its not out of range
        for (int i = 0; i < position - 1; i++) {
            if (temp == null) {
                return;
            }
            temp = temp.Next;
        }

        if (temp == null) {
            Console.WriteLine("Position out of range");
            return;
        }

        Node<T> new_node = new Node<T>(data, temp.Next);
        temp.Next = new_node;
    }


    public void deleteNode(T data) {
        if (head == null) {
            return;
        }
        
        if (head.Data.Equals(data)) {
            head = head.Next;
            return;
        }

        Node<T> temp = head;
        while (temp.Next != null) {
            if (temp.Next.Data.Equals(data)) {
                temp.Next = temp.Next.Next;
                return;
            }
            temp = temp.Next;
        }
    }


    public Boolean inList(T data) {
        Node<T> temp = head;
        while (temp != null) {
            if (temp.Data.Equals(data)) {
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }


    // Print list 
    public void printList() {
        Node<T> temp = head;
        while (temp != null) {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
    }

    public void bubbleSort() {
        bool swapped;
        
        // Listan är tom eller har bara ett element
        if (head == null || head.Next == null) {
            return; 
        }

        do {
            swapped = false;
            Node<T>? current = head;
            Node<T>? prev = null;

            while (current != null && current.Next != null)
            {
                if (Comparer<T>.Default.Compare(current.Data, current.Next.Data) > 0) {
                    // Byt noder genom att justera pointer
                    Node<T>? next = current.Next;
                    current.Next = next.Next;
                    next.Next = current;

                    if (prev == null) {
                        head = next; // Uppdatera huvudet om de två första noderna byts ut
                    }
                    else {
                        prev.Next = next;
                    }

                    swapped = true;
                }

                prev = (swapped && prev == null) ? head : current;
                current = current.Next;
            }
        } while (swapped);
    }


    public void reverseList() {
        Node<T>? prev = null;
        Node<T>? current = head;
        Node<T>? next = null;

        while (current != null) {
            next = current.Next; // Store next node
            current.Next = prev; // Reverse the link
            prev = current;      // Move prev to current node
            current = next;      // Move to next node
        }

        head = prev; // Update head to the new first node
    }
}