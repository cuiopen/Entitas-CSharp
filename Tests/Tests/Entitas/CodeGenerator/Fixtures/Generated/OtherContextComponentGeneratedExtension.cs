//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public OtherContextComponent otherContext { get { return (OtherContextComponent)GetComponent(OtherComponentIds.OtherContext); } }
        public bool hasOtherContext { get { return HasComponent(OtherComponentIds.OtherContext); } }

        public void AddOtherContext(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var component = CreateComponent<OtherContextComponent>(OtherComponentIds.OtherContext);
            component.timestamp = newTimestamp;
            component.isLoggedIn = newIsLoggedIn;
            AddComponent(OtherComponentIds.OtherContext, component);
        }

        public void ReplaceOtherContext(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var component = CreateComponent<OtherContextComponent>(OtherComponentIds.OtherContext);
            component.timestamp = newTimestamp;
            component.isLoggedIn = newIsLoggedIn;
            ReplaceComponent(OtherComponentIds.OtherContext, component);
        }

        public void RemoveOtherContext() {
            RemoveComponent(OtherComponentIds.OtherContext);
        }
    }

    public partial class Context {

        public Entity otherContextEntity { get { return GetGroup(OtherMatcher.OtherContext).GetSingleEntity(); } }
        public OtherContextComponent otherContext { get { return otherContextEntity.otherContext; } }
        public bool hasOtherContext { get { return otherContextEntity != null; } }

        public Entity SetOtherContext(System.DateTime newTimestamp, bool newIsLoggedIn) {
            if(hasOtherContext) {
                throw new EntitasException("Could not set otherContext!\n" + this + " already has an entity with OtherContextComponent!",
                    "You should check if the context already has a otherContextEntity before setting it or use context.ReplaceOtherContext().");
            }
            var entity = CreateEntity();
            entity.AddOtherContext(newTimestamp, newIsLoggedIn);
            return entity;
        }

        public Entity ReplaceOtherContext(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var entity = otherContextEntity;
            if(entity == null) {
                entity = SetOtherContext(newTimestamp, newIsLoggedIn);
            } else {
                entity.ReplaceOtherContext(newTimestamp, newIsLoggedIn);
            }

            return entity;
        }

        public void RemoveOtherContext() {
            DestroyEntity(otherContextEntity);
        }
    }
}

    public partial class OtherMatcher {

        static IMatcher _matcherOtherContext;

        public static IMatcher OtherContext {
            get {
                if(_matcherOtherContext == null) {
                    var matcher = (Matcher)Matcher.AllOf(OtherComponentIds.OtherContext);
                    matcher.componentNames = OtherComponentIds.componentNames;
                    _matcherOtherContext = matcher;
                }

                return _matcherOtherContext;
            }
        }
    }