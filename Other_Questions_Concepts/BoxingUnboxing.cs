namespace Other_Questions_Concepts
{
    public class BoxingUnboxing
    {
        public void BoxingUnboxingMethod()
        {
            #region Boxing and Unboxing            

            int num = 10;

            object boxValue = num; // Boxing

            int unboxValue = (int)boxValue; // Unboxing
            #endregion
        }
    }
}

/*
 Q. Boxing vs Unboxing

Boxing
=======
- Converting from any type to object called as Boxing 
- Its happer automatically (convertion is not required)

Unboxing:
=========
- We conver the object type data in to normal type - Unboxing
- Conversion is requeired


int num = 10;

object boxValue = num; // Boxing

int unboxValue = (int)boxValue; // Unboxing
 */
