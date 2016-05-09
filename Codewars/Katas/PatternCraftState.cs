﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PatternCraftState
{
    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }

    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }

    public class SiegeState : IUnitState
    {
        public SiegeState()
        {

        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class TankState : IUnitState
    {
        public TankState()
        {

        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class Tank : IUnit
    {
        public Tank()
        {

        }

        public IUnitState State { get; set; }

        public bool CanMove { get; }
        public int Damage { get; }
    }
}
