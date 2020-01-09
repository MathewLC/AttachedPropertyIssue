using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AttachedPropertiesIssue
{

    public class MyCustomClass
    {
        public string ExampleProperty1 { get; set; }
    }

    public class StackLayoutProperties
    {
        public static readonly BindableProperty StackLayoutCollectionProperty =
            BindableProperty.CreateAttached("StackLayoutCollection",
                typeof(IList<MyCustomClass>),
                typeof(StackLayoutProperties),
                new List<MyCustomClass>());

        public static IList<MyCustomClass> GetStackLayoutCollection(BindableObject view) => (IList<MyCustomClass>)view.GetValue(StackLayoutCollectionProperty);
        public static void SetStackLayoutCollection(BindableObject view, IList<MyCustomClass> value) => view.SetValue(StackLayoutCollectionProperty, value);
    }
}
