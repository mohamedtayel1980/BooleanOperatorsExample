namespace BooleanOperatorsExample
{
    internal class Program
    {
        static void Main()
        {
            #region Relational Operators
            RelationalOperators();
            #endregion

            #region Logical AND (&&)
            LogicalAndExample();
            #endregion

            #region Logical OR (||)
            LogicalOrExample();
            #endregion

            #region Complex Conditions with AND and OR
            ComplexConditions();
            #endregion

            #region Combining AND (&&) and OR (||)
            CombiningAndOrExample();
            #endregion
        }

        #region Relational Operators
        static void RelationalOperators()
        {
            int age = 30;

            // Check if the age is equal to 30
            bool isThirty = age == 30;
            Console.WriteLine("Is age 30: " + isThirty);

            // Check if the age is greater than 30
            bool isGreaterThanThirty = age > 30;
            Console.WriteLine("Is age greater than 30: " + isGreaterThanThirty);
        }
        #endregion

        #region Logical AND (&&)
        static void LogicalAndExample()
        {
            int personAge = 35;

            // Check if the age is between 18 and 65
            bool isValidAge = (personAge >= 18) && (personAge <= 65);
            Console.WriteLine("Is age between 18 and 65: " + isValidAge);
        }
        #endregion

        #region Logical OR (||)
        static void LogicalOrExample()
        {
            int personAge1 = 17;
            int personAge2 = 40;

            // Check if either personAge1 is greater than 18 or personAge2 is less than 65
            bool isEitherConditionTrue = (personAge1 >= 18) || (personAge2 <= 65);
            Console.WriteLine("Is either condition true: " + isEitherConditionTrue);
        }
        #endregion

        #region Complex Conditions with AND and OR
        static void ComplexConditions()
        {
            int age1 = 20;
            int age2 = 70;

            // Logical AND (both conditions must be true)
            bool areBothAgesValid = (age1 >= 18) && (age2 <= 65);
            Console.WriteLine("Are both ages valid: " + areBothAgesValid);

            // Logical OR (either condition can be true)
            bool isEitherAgeValid = (age1 >= 18) || (age2 <= 65);
            Console.WriteLine("Is either age valid: " + isEitherAgeValid);
        }
        #endregion

        #region Combining AND (&&) and OR (||)
        static void CombiningAndOrExample()
        {
            int age = 17;
            bool isVIP = true;
            double purchaseAmount = 120.0;

            // Check if the person is eligible for a special offer
            bool isEligible = ((age > 18) || isVIP) && (purchaseAmount >= 100);
            Console.WriteLine("Is the person eligible for the special offer: " + isEligible);
        }
        #endregion
    }
}
