using CompositeBaseExample;

var composite = new Composite();
composite.Add(new Leaf());
composite.Add(new Leaf());
var composite2 = new Composite();
composite2.Add(new Leaf());
composite2.Add(new Leaf());

composite.Add(composite2);

composite.Operation();