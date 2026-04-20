// Write a CharberryTree class that fruits and a Notifier class that notifies when said fruit is ripened.
// Write a Harvester class that resets the state of ripened fruit in the CharberryTree class.
// Fire an event in the CharberryTree class and listen on the Notifier and Harvester classes.
// See book for details.

CharberryTree tree = new CharberryTree();
Notifier notifier = new Notifier(tree);
Harvester harvester = new Harvester(tree);

while(true)
    tree.MaybeGrow();

