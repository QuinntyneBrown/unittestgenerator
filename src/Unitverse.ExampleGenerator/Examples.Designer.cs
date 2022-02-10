﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unitverse.ExampleGenerator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Examples {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Examples() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Unitverse.ExampleGenerator.Examples", typeof(Examples).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Abstract Classes
        ///// $ Demonstrates how Unitverse generates tests when the source class is abstract or contains protected methods, as well as how inheritance chains are accounted for
        ///
        ///using System.IO;
        ///using System.Windows;
        ///
        ///namespace Unitverse.Examples {
        ///    public abstract class TestClass
        ///    {
        ///        protected TestClass()
        ///        { }
        /// 
        ///        protected abstract int AbstractMethod();
        ///
        ///        protected virtual int ProtectedMethod() =&gt; 1;
        ///
        ///        public virtual int SomeMethod(int i) = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AbstractClass {
            get {
                return ResourceManager.GetString("AbstractClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Async Methods
        ///// $ Demonstrates how tests are generated for async methods, as well as showing how the assertion framework is driven differently for async methods
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class TestClass
        ///    {
        ///        public System.Threading.Tasks.Task ThisIsAnAsyncMethod(string methodName, int methodValue)
        ///        {
        ///            System.Console.WriteLine(&quot;Testing this&quot;);
        ///            return System.Threading.Tasks.Task.CompletedTask;
        ///        }
        ///
        ///        public System.Threading [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AsyncMethod {
            get {
                return ResourceManager.GetString("AsyncMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Automatic Mock Generation
        ///// $ Demonstrates how dependencies injected into constructors are tracked, and mock configuration calls emitted for any detected dependencies
        ///
        ///using System.Threading.Tasks;
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface IDummyService
        ///    {
        ///        string SomeProp { get; set; }
        ///
        ///        void NoReturnMethod();
        ///
        ///        int ReturnMethod();
        ///
        ///        T GenericMethod&lt;T&gt;(T val);
        ///
        ///        Task&lt;string&gt; AsyncMethod(); 
        ///    }
        ///
        ///    public interface IDummyService2 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AutomaticMockGeneration {
            get {
                return ResourceManager.GetString("AutomaticMockGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Constrained Generic Types
        ///// $ Demonstrates how appropriate types are selected for the generation of tests for generic types with type constraints
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface ITest
        ///    {
        ///        int ThisIsAProperty { get; set; }
        ///    }
        ///
        ///    public interface ITest2
        ///    {
        ///        int ThisIsAnotherProperty { get; set; }
        ///    }
        ///
        ///    public class Test : ITest
        ///    {
        ///        public int ThisIsAProperty { get; set; }
        ///    }
        ///
        ///    public class TestBoth : ITest, ITest2
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConstrainedGenericType {
            get {
                return ResourceManager.GetString("ConstrainedGenericType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Delegate Generation
        ///// $ Demonstrates how Unitverse generates default values for method parameters when the parameter is a delegate type
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System;
        ///
        ///    public class SomeClass
        ///    {
        ///        public SomeClass(int val)
        ///        {
        ///            Val = val;
        ///        }
        ///
        ///        public int Val { get; }
        ///    }
        ///
        ///    public static class TestClass
        ///    {
        ///        public static void ThisIsAMethod(Func&lt;string&gt; func)
        ///        {
        ///        }
        ///
        ///        public static voi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DelegateGeneration {
            get {
                return ResourceManager.GetString("DelegateGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Extension Methods
        ///// $ Demonstrates how Unitverse generates tests for extension methods
        ///
        ///using System;
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public static class ExtensionMethodClass 
        ///    {
        ///        public static string ToOther(this string source)
        ///        {
        ///            return source;
        ///        }
        ///
        ///        public static  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExtensionMethod {
            get {
                return ResourceManager.GetString("ExtensionMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Frameworks - Fluent Assertions
        ///// $ Demonstrates how tests are generated using XUnit for the test framework and NSubstitute for the mocking framework. Also shows using FluentAssertions for the assertion framework.
        ///// # FrameworkType=XUnit
        ///// # MockingFrameworkType=NSubstitute
        ///// # UseFluentAssertions=true
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface IDependency
        ///    {
        ///        void Method();
        ///    }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(IDependency dependency)
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameworksFluentAssertions {
            get {
                return ResourceManager.GetString("FrameworksFluentAssertions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Frameworks - MSTest &amp; Moq
        ///// $ Demonstrates how tests are generated using MsTest for the test framework and Moq for the mocking framework
        ///// # FrameworkType=MSTest
        ///// # MockingFrameworkType=Moq
        ///// # UseFluentAssertions=false
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface IDependency
        ///    {
        ///        void Method();
        ///    }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(IDependency dependency)
        ///        { }
        ///
        ///        public void SomeMethod(string methodName, int methodValue)
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameworksMsTestMoq {
            get {
                return ResourceManager.GetString("FrameworksMsTestMoq", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Frameworks - NUnit 3 &amp; FakeItEasy
        ///// $ Demonstrates how tests are generated using NUnit 3 for the test framework and FakeItEasy for the mocking framework
        ///// # FrameworkType=NUnit3
        ///// # MockingFrameworkType=FakeItEasy
        ///// # UseFluentAssertions=false
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface IDependency
        ///    {
        ///        void Method();
        ///    }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(IDependency dependency)
        ///        { }
        ///
        ///        public void SomeMethod(string methodN [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameworksNUnitFakeItEasy {
            get {
                return ResourceManager.GetString("FrameworksNUnitFakeItEasy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Frameworks - XUnit &amp; NSubstitute
        ///// $ Demonstrates how tests are generated using XUnit for the test framework and NSubstitute for the mocking framework
        ///// # FrameworkType=XUnit
        ///// # MockingFrameworkType=NSubstitute
        ///// # UseFluentAssertions=false
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface IDependency
        ///    {
        ///        void Method();
        ///    }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(IDependency dependency)
        ///        { }
        ///
        ///        public void SomeMethod(string methodNam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameworksXUnitNSubstitute {
            get {
                return ResourceManager.GetString("FrameworksXUnitNSubstitute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Generic Methods
        ///// $ Demonstrates how Unitverse generates tests for generic methods
        ///
        ///using System;
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class GenericSource
        ///    {
        ///        public void DoStuff&lt;T&gt;(Guid g, DateTime dtParam, T theThing, int? thing2)
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string GenericMethod {
            get {
                return ResourceManager.GetString("GenericMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! IComparable
        ///// $ Demonstrates the tests generated for a type that implements IComparable
        ///
        ///using System;
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class TestComparableGeneric : IComparable&lt;TestComparableGeneric&gt;, IComparable&lt;int&gt;, IComparable
        ///    {
        ///        public TestComparableGeneric(int value)
        ///        {
        ///            Value = value;
        ///        }
        ///
        ///        public int Value { get; }
        ///
        ///        public int CompareTo(TestComparableGeneric obj)
        ///        {
        ///            if (obj == null)
        ///            { [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IComparableTests {
            get {
                return ResourceManager.GetString("IComparableTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Indexers
        ///// $ Demonstrates the tests generated for a type that contains an indexer
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class TypeWithIndexer 
        ///    {
        ///        public string this[string cookieName]
        ///        {
        ///            get { return &quot;hello&quot;; }
        ///        } 
        ///
        ///        public string this[string cookieName, int cookieId]
        ///        {
        ///            get { return &quot;hello&quot;; }
        ///            set { }
        ///        } 
        ///    }
        ///}.
        /// </summary>
        internal static string IndexerTests {
            get {
                return ResourceManager.GetString("IndexerTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Mapping Methods
        ///// $ Shows how unitverse generates a test to verify mappings between input parameter type and return type where the types share property names
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class InputClass
        ///    {
        ///        public string SomeProperty { get; }
        ///        public string SomeOtherProperty { get; set; }
        ///        public string InputOnlyProperty { get; set; }
        ///    }
        ///
        ///    public class OutputClass
        ///    {
        ///        public string SomeProperty { get; set; }
        ///        public string So [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MappingMethod {
            get {
                return ResourceManager.GetString("MappingMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Multiple Overloads
        ///// $ Shows how unitverse generates unambiguous names for methods that test multiple overloads of the same source method
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System;
        ///    using System.Collections.Generic;
        ///    using System.Linq;  
        ///    
        ///    public enum Stage
        ///    {
        ///        First,
        ///		Second,
        ///		Third,
        ///		Fourth,
        ///    }
        ///
        ///    public static class FluentFactory
        ///    {
        ///        public static Tuple&lt;Stage, IList&lt;Stage&gt;&gt; Follows(this Stage stage, params Stage[] followedStages)
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MultipleOverloads {
            get {
                return ResourceManager.GetString("MultipleOverloads", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Nullable Reference Types
        ///// $ Shows how Unitverse will omit `null` tests for parameters declared to explicitly accept null
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public interface ITest { }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(string notNullable, string? nullable)
        ///        {
        ///        }
        /// 
        ///        public TestClass(ITest? test)
        ///        {
        ///        }
        /// 
        ///        public TestClass(ITest test, string someOtherThing)
        ///        {
        ///        }
        /// 
        ///        public string GetFullName(strin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NullableReferenceTypes {
            get {
                return ResourceManager.GetString("NullableReferenceTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Operator Overloading
        ///// $ Shows how Unitverse emits tests for declared unary and binary operators
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System;
        ///
        ///    class Calculator 
        ///	{ 
        ///        public int number = 0; 
        ///      
        ///        public Calculator(int n) 
        ///        { 
        ///            number = n; 
        ///        } 
        ///      
        ///        public static Calculator operator + (Calculator Calc1, Calculator Calc2) 
        ///        { 
        ///            Calculator Calc3 = new Calculator(0); 
        ///            Calc3.number = Calc2.number +  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OperatorOverloading {
            get {
                return ResourceManager.GetString("OperatorOverloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! POCO Initialization
        ///// $ Demonstrates how test values are produced to initialize POCO members when the type is consumed
        ///
        ///namespace Unitverse.Examples
        ///{
        ///	using System;
        ///
        ///    public class SomePoco
        ///    {
        ///        public int Identity { get; set; }
        ///        public string Description { get; set; }
        ///        public Guid UniqueCode { get; set; }
        ///    }
        ///
        ///    public class ConsumingClass
        ///    {
        ///		SomePoco _poco;
        ///
        ///        public ConsumingClass(SomePoco poco)
        ///        {
        ///			_poco = poco;
        ///        }
        /// 
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PocoInitialization {
            get {
                return ResourceManager.GetString("PocoInitialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Record Types (init Properties)
        ///// $ Demonstrates the tests generated for a record type that has properties that have init accessors
        ///
        ///using System;
        ///using System.Collections.Generic;
        ///
        ///namespace TestNamespace 
        ///{
        ///    record Person
        ///    {
        ///        private readonly string _firstName;
        ///        private readonly string _lastName;
        ///    
        ///        public Guid Id { get; init; }
        ///    
        ///        public string FirstName
        ///        {
        ///            get =&gt; _firstName;
        ///            init =&gt; _firstName = (value ?? throw [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RecordTypeInitProperties {
            get {
                return ResourceManager.GetString("RecordTypeInitProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Record Types (Primary Constructor)
        ///// $ Demonstrates the tests generated for a simple primary constructor record type
        ///
        ///namespace TestNamespace 
        ///{
        ///	public record RecordType(string StringProperty, int IntProperty);
        ///}.
        /// </summary>
        internal static string RecordTypesPrimaryConstructor {
            get {
                return ResourceManager.GetString("RecordTypesPrimaryConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! ref &amp; out Parameters
        ///// $ Demonstrates the tests that Unitverse emits when methods contain `ref` or `out` parameters
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    public class TestClass
        ///    {
        ///        public void RefParamMethodString(string stringProp, ref string refParam)
        ///        {
        ///
        ///        }
        /// 
        ///        public void OutParamMethodString(string stringProp, out string outParam)
        ///        {
        ///            outParam = &quot;&quot;;
        ///        }
        ///
        ///        public void RefParamMethodClass(string stringProp, ref TestClass re [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RefAndOutParameters {
            get {
                return ResourceManager.GetString("RefAndOutParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Simple POCO
        ///// $ Demonstrates how tests are generated for a simple POCO type
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System;
        ///
        ///    public class SomePoco
        ///    {
        ///        public int Identity { get; set; }
        ///        public string Description { get; set; }
        ///        public Guid UniqueCode { get; set; }
        ///    }
        ///}.
        /// </summary>
        internal static string SimplePoco {
            get {
                return ResourceManager.GetString("SimplePoco", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Singletons
        ///// $ Demonstrates how Unitverse attempts to use a static property to get a type instance when the constructor is private
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System;
        ///
        ///    public class TestClass
        ///    {
        ///        static TestClass()
        ///        {
        ///            Instance = new TestClass();
        ///        }
        ///
        ///        private TestClass()
        ///        {
        ///        }
        ///
        ///        public static TestClass Instance { get; }
        ///
        ///        public bool IsShared =&gt; true;
        ///
        ///        public string GetTableName(string  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Singleton {
            get {
                return ResourceManager.GetString("Singleton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // ! Static Classes
        ///// $ Demonstrates how Unitverse generates tests when the source class is static
        ///
        ///namespace Unitverse.Examples
        ///{
        ///    using System.Globalization;
        ///
        ///    public static class TestClass
        ///    {
        ///        public static void ThisIsAMethod(string methodName, CultureInfo methodValue)
        ///        {
        ///            System.Console.WriteLine(&quot;Testing this&quot;);
        ///        }
        ///
        ///        public static string WillReturnAString()
        ///        {
        ///            return &quot;Hello&quot;;
        ///        }
        ///
        ///        public static int This [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string StaticClass {
            get {
                return ResourceManager.GetString("StaticClass", resourceCulture);
            }
        }
    }
}
