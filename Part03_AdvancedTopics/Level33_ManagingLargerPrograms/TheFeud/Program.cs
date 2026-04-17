// Crete two namespaces IField and McDroid with classes Sheep, Pig, and Cow, Pig respectively. 
// Make new instances of all 4 classes, resolving any name conflicts that may arise.

using IField;
using McDroid;

Sheep sheep = new Sheep();
IField.Pig IFieldPig = new IField.Pig();

Cow cow = new Cow();
McDroid.Pig mcPig = new McDroid.Pig();

namespace IField
{
    class Sheep { }
    class Pig { }
}

namespace McDroid
{
    class Cow { }
    class Pig { }
}