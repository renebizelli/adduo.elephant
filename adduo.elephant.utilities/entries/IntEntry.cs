﻿using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class IntEntry : Entry<string>
    {
        public IntEntry()
        {
            AddValidation(new entry_validarions.IsAnInt());
        }

        public int GetValue()
        {
            var n = 0;

            int.TryParse(Value, out n) ;

            return n;
        }

    }


}
