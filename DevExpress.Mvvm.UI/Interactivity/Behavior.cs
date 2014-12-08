using System;
#if !NETFX_CORE
using System.Windows;
#else
using Windows.UI.Xaml;
#endif

namespace DevExpress.Mvvm.UI.Interactivity {
    public abstract class Behavior : AttachableObjectBase {
        internal Behavior(Type type)
            : base(type) {
        }
    }
    public abstract class Behavior<T> : Behavior where T : DependencyObject {
        protected Behavior()
            : base(typeof(T)) {
        }
        protected new T AssociatedObject {
            get { return (T)base.AssociatedObject; }
        }
    }
}