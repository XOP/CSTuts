using System;

namespace PassGen
{
    enum CharType
    {
        Letter = 1,
        Number = 2,
        Caps = 3,
        Special = 4
    }

    public class PassGenerator
    {
        public byte Min = 12;
        public byte Max = 12;
        public bool HasNumber = true;
        public bool HasCaps = false;
        public bool HasSpecials = false;

        private int[] ActiveTypes = new int[4];

        private static readonly Random R = new Random();
        private static readonly string[] SP = { "@", "#", "$", "%", "&", "*", "(", ")", "-", "+" };

        byte PassLength()
        {
            return (byte)R.Next(Min, Max);
        }

        void UpdatePassOptions()
        {
            ActiveTypes[0] = (int)CharType.Letter;

            if (HasNumber)
            {
                ActiveTypes[1] = (int)CharType.Number;
            }

            if (HasCaps)
            {
                ActiveTypes[2] = (int)CharType.Caps;
            }

            if (HasSpecials)
            {
                ActiveTypes[3] = (int)CharType.Special;
            }
        }

        int NextCharType()
        {
            var total = ActiveTypes.Length;
            var key = R.Next(0, total);

            return ActiveTypes[key];
        }

        int GenerateNumber()
        {
            return R.Next(0, 10);
        }

        string GenerateSpecial()
        {
            return SP[R.Next(0, SP.Length)];
        }

        string GenerateLetter()
        {
            var newChar = (char)R.Next(97, 122);

            return newChar.ToString();
        }

        public string Generate()
        {
            UpdatePassOptions();

            var passLength = PassLength();
            var passBuff = new string[passLength];

            for (var i = 0; i < passLength; i++)
            {
                var sym = "a";

                switch (NextCharType())
                {
                    case (int)CharType.Letter:
                        sym = GenerateLetter();
                        break;

                    case (int)CharType.Caps:
                        sym = GenerateLetter().ToUpper();
                        break;

                    case (int)CharType.Number:
                        var num = GenerateNumber();
                        sym = num.ToString();
                        break;

                    case (int)CharType.Special:
                        var sp = GenerateSpecial();
                        sym = sp;
                        break;
                }

                passBuff[i] = sym;
            }

            return string.Join("", passBuff);
        }
    }
}
