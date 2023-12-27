namespace POCs.OOPsConcepTsExploring
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            #region valuetypeVsRefType
            Console.WriteLine("Test1:Value type vs Ref type");
            Console.WriteLine($"Step1:ValueType");
            int a1 = 10;
            Console.WriteLine($"Calling {nameof(ChangeValue)} with {nameof(a1)}:{a1}");
            ChangeValue(a1);
            Console.WriteLine($"result={a1}");
            Console.WriteLine();
            Console.WriteLine($"Step2:ReferenceType");
            BaseClass b = new BaseClass();
            b.MyPropertyInt = 100;
            Console.WriteLine($"Calling {nameof(ChangeReferenceType)} with {nameof(b.MyPropertyInt)}:{b.MyPropertyInt}");
            ChangeReferenceType(b);//no need to get return result & assign back to main object
            Console.WriteLine($"result={b.MyPropertyInt}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.ReadLine();
            #endregion valuetypeVsRefType
            //  b.NormalProperty2 = 1;

            // AbstractBaseClass a = new AbstractBaseClass();//1.not allowed to create abstract instance
            //  b.NormalProperty2 = 1;
            Console.ReadLine();
            }
        static void ChangeValue(int x)
            {
            Console.WriteLine($"{nameof(ChangeValue)}: Before {x}");
            x = 200;
            Console.WriteLine($"{nameof(ChangeValue)}: After {x}");
            }
        static void ChangeReferenceType(BaseClass std2)
            {
            Console.WriteLine($"{nameof(ChangeReferenceType)}: Before {std2.MyPropertyInt}");
            std2.MyPropertyInt = 200;//no need to return & assign back to main object
            Console.WriteLine($"{nameof(ChangeReferenceType)}: After {std2.MyPropertyInt}");
            }
        }

    public class BaseClass : AbstractBaseClass
        {

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

        }

    public abstract class AbstractBaseClass
        {
        private string stringField = "From Abstract class private stringField";//encapsulation
        private string stringFieldOther = "From Abstract class private stringFieldOther";//encapsulation

        public string MyString1 { get { return stringField; } set { stringField = value; } }

        public string? NormalProperty1 { get; set; }
        public string? NormalProperty2 { get; set; }
        public abstract string? AbstractProperty1 { get; set; }
        public abstract string? AbstractProperty2 { get; set; }
        }
    }
