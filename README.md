StatList
By Jeff Gaston

The StatList was created to easily support fast queries about aggregates or locations of contents of a list.

When the caller creates the StatList, the caller can provide an aggregator (for example, a service that adds two numbers). The StatList is implemented as a binary tree and uses the aggregator to keep its aggregate up-to-date. In this example, this StatList would support fast queries of the form "find the the sum of all elements from indexes A to B".

Each element has both a key and a value so you may think of the StatList like a TreeMap if you prefer. I think of it as a list where the indexes are user-defined objects rather than integers.