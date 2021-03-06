//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DontDrawSimpleObjectComponent dontDrawSimpleObject { get { return (DontDrawSimpleObjectComponent)GetComponent(GameComponentsLookup.DontDrawSimpleObject); } }
    public bool hasDontDrawSimpleObject { get { return HasComponent(GameComponentsLookup.DontDrawSimpleObject); } }

    public void AddDontDrawSimpleObject(SimpleObject newSimpleObject) {
        var index = GameComponentsLookup.DontDrawSimpleObject;
        var component = CreateComponent<DontDrawSimpleObjectComponent>(index);
        component.simpleObject = newSimpleObject;
        AddComponent(index, component);
    }

    public void ReplaceDontDrawSimpleObject(SimpleObject newSimpleObject) {
        var index = GameComponentsLookup.DontDrawSimpleObject;
        var component = CreateComponent<DontDrawSimpleObjectComponent>(index);
        component.simpleObject = newSimpleObject;
        ReplaceComponent(index, component);
    }

    public void RemoveDontDrawSimpleObject() {
        RemoveComponent(GameComponentsLookup.DontDrawSimpleObject);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDontDrawSimpleObject;

    public static Entitas.IMatcher<GameEntity> DontDrawSimpleObject {
        get {
            if (_matcherDontDrawSimpleObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DontDrawSimpleObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDontDrawSimpleObject = matcher;
            }

            return _matcherDontDrawSimpleObject;
        }
    }
}
