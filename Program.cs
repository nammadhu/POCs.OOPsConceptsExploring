namespace POCs.OOPsConcepTsExploring
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            BaseClass b = new BaseClass();
          //  b.NormalProperty2 = 1;

            // AbstractBaseClass a = new AbstractBaseClass();//1.not allowed to create abstract instance
          //  b.NormalProperty2 = 1;
            Console.WriteLine("Hello, World!");
            }
        }
    public class BaseClass : AbstractBaseClass
        {

        private string stringField = "From Base class private stringField";//encapsulation
        private string stringFieldOther = "From Base class private stringFieldOther";//encapsulation

        public string MyStringOnlyGet { get { return stringField; } }//NO SETTING,only get 
        public string MyStringOnlyGetOther { get { return stringFieldOther; } }//NO SETTING,only get 
        public string MyStringMixed { get { return stringField; } set { stringFieldOther = value; } }//read from one,write to other
        public string MyString { get { return stringField; } set { stringField = value; } }
        //if above scenario then can directly use as below
        public string? MyStringProperty { get; set; }



        public string? NormalProperty1 { get { return stringField; }  set{}  }//this hiding baseclass property

        //below also hiding baseclass property but using that property with local customization
        public string? NormalProperty2 { get { return base.NormalProperty1; } set { base.NormalProperty1 = value+NormalProperty1+ base.MyString1; } }


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
