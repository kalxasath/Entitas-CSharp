//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly FlagEventComponent flagEventComponent = new FlagEventComponent();

    public bool isFlagEvent {
        get { return HasComponent(TestComponentsLookup.FlagEvent); }
        set {
            if (value != isFlagEvent) {
                var index = TestComponentsLookup.FlagEvent;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : flagEventComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherFlagEvent;

    public static Entitas.IMatcher<TestEntity> FlagEvent {
        get {
            if (_matcherFlagEvent == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagEvent);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherFlagEvent = matcher;
            }

            return _matcherFlagEvent;
        }
    }
}
