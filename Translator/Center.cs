﻿using System;

namespace Translator
{
    internal class Center : Player
    {
        public Center(string name)
            : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"中锋 {Name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋 {Name} 防守");
        }
    }
}