using System;
using System.Collections.Generic;
using System.Linq;

public class PriorityQueue<TValue, TPriority> where TPriority : IComparable<TPriority>
{
    private readonly List<(TValue Value, TPriority Priority)> _items = new();

    /// <summary>
    /// Adds an item to the queue with the specified priority.
    /// </summary>
    public void Enqueue(TValue value, TPriority priority)
    {
        _items.Add((value, priority));
    }

    /// <summary>
    /// Removes and returns the item with the highest priority.
    /// If multiple items have the same priority, the one added first is returned.
    /// </summary>
    public TValue Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the item with the highest priority
        var highestPriorityIndex = 0;
        for (int i = 1; i < _items.Count; i++)
        {
            if (_items[i].Priority.CompareTo(_items[highestPriorityIndex].Priority) > 0)
            {
                highestPriorityIndex = i;
            }
        }

        var item = _items[highestPriorityIndex];
        _items.RemoveAt(highestPriorityIndex);
        return item.Value;
    }

    /// <summary>
    /// Returns the number of items in the queue.
    /// </summary>
    public int Count => _items.Count;
}