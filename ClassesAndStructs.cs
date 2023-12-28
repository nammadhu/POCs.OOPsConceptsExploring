using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCs.OOPsConceptsExploring
    {
    public class ClassesAndStructs
        {

        public class SimpleClass
            {
            public int SimpleClassInt { get; set; } = 3;

            public string? SimpleClassString { get; set; } = "default Madhu";
            public SimpleClass GetClone()
                {
                return (SimpleClass)this.MemberwiseClone();
                }

            public object Clone()
                {
                return new SimpleClass
                    {
                    SimpleClassInt = SimpleClassInt,
                    SimpleClassString = SimpleClassString
                    };
                }

            }
        public class DerivedClass : BaseClass
            {

            public DerivedClass()
                {
                DerivedProperty1 = $"{nameof(DerivedProperty1)} from {nameof(DerivedClass)}";
                Console.WriteLine($"Am from {nameof(DerivedClass)}-constructor");
                }
            public string? DerivedProperty1 { get; set; }
            }
        public class BaseClass : AbstractBaseClass, IDisposable
            {
            public BaseClass()//
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-constructor");
                }
            public BaseClass(int a):base(a)//
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-constructor with parameter:{a}");
                }
            public BaseClass(string a) : base(a)//
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-constructor with parameter:{a}");
                }
            public BaseClass(float a) : this()//
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-constructor with parameter:{a}");
                }
            public object Clone()
                {
                return new BaseClass//since here cant create new so doing it on next level BaseClass
                    {
                    SimpleClass1 = (SimpleClass)SimpleClass1.Clone(),
                    MyPropertyInt = MyPropertyInt,
                    MyString = MyString,
                    MyStringProperty = MyStringProperty
                    //IF remaining are not done then it will be omitted so may be other option like memberwiseclone & mix of this CLone()
                    };
                }
            //BaseClass(int a)//
            //    {
            //    Console.WriteLine($"Am from {nameof(BaseClass)}-constructor");
            //    }
            ~BaseClass()//no access specifiers for Destructor
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-Destructor");
                }
            public int MyPropertyInt { get; set; }
            private string stringField = "From Base class private stringField";//encapsulation
            private string stringFieldOther = "From Base class private stringFieldOther";//encapsulation

            public string MyStringOnlyGet { get { return stringField; } }//NO SETTING,only get 
            public string MyStringOnlyGetOther { get { return stringFieldOther; } }//NO SETTING,only get 
            public string MyStringMixed { get { return stringField; } set { stringFieldOther = value; } }//read from one,write to other
            public string MyString { get { return stringField; } set { stringField = value; } }
            //if above scenario then can directly use as below
            public string? MyStringProperty { get; set; }



            public string? NormalProperty1 { get { return stringField; } set { } }//this hiding baseclass property

            //below also hiding baseclass property but using that property with local customization
            public string? NormalProperty2 { get { return base.NormalProperty1; } set { base.NormalProperty1 = value + NormalProperty1 + base.MyString1; } }


            //public string? AbstractProperty1 { get; set; }//this is allowed but class expects must implemnt abstract method so below
            public override string? AbstractProperty1 { get; set; }
            public override string? AbstractProperty2 { get; set; }

            public new void NormalMethod1()
                {
                base.NormalMethod1();
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-{nameof(NormalMethod1)} & ");
                }
            public override void AbstractMethod()
                {
                Console.WriteLine($"Am from {nameof(BaseClass)}-{nameof(AbstractMethod)} ");
                }

            public void Dispose()
                {
                Console.WriteLine($"Dispose called of {nameof(BaseClass)}");
                }
            }

        public abstract class AbstractBaseClass : IDisposable
            {
            public SimpleClass SimpleClass1 { get; set; } = new SimpleClass();
            public AbstractBaseClass()
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-Constructor ");
                }
            public AbstractBaseClass(int a)
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-Constructor with int a:{a}");
                }
            public AbstractBaseClass(string a):this()
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-Constructor with int a:{a}");
                }
            ~AbstractBaseClass()
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-Destructor");
                }
            public object ShallowCopy()
                {
                return this.MemberwiseClone();
                }
            public object DeepCopy()
                {
                var o = (AbstractBaseClass)this.MemberwiseClone();
                o.SimpleClass1 = SimpleClass1.GetClone();//if this is not exists then it becomes same ref changes & same like shallow copy
                return o;
                }
            //public object Clone()
            //    {
            //    return new AbstractBaseClass//since here cant create new so doing it on next level BaseClass
            //        {
            //        SimpleClass1 = SimpleClassInt,
            //        SimpleClassString = SimpleClassString
            //        };
            //    }
            public void Dispose()
                {
                Console.WriteLine($"Dispose called of {nameof(AbstractBaseClass)}");
                }
            private string stringField = "From Abstract class private stringField";//encapsulation
            private string stringFieldOther = "From Abstract class private stringFieldOther";//encapsulation

            public string MyString1 { get { return stringField; } set { stringField = value; } }

            public string? NormalProperty1 { get; set; }
            public string? NormalProperty2 { get; set; }
            public abstract string? AbstractProperty1 { get; set; }
            public abstract string? AbstractProperty2 { get; set; }
            public void NormalMethod1()
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-{nameof(NormalMethod1)} ");
                }
            public void NormalMethod2()
                {
                Console.WriteLine($"Am from {nameof(AbstractBaseClass)}-{nameof(NormalMethod2)} ");
                }
            public abstract void AbstractMethod();//no definition or body,but this must be implemented later

            }

        public struct PointStructure
            {
            public PointStructure(byte tag, double x, double y) => (Tag, X, Y) = (tag, x, y);

            public byte Tag { get; }
            public double X { get; }
            public double Y { get; }
            }
        }
    }
