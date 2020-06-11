﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Fargowiltas.Items.Ammos.Darts
{
    class CrystalDartBox : BaseAmmo
    {
        public override int AmmunitionItem => ItemID.CrystalDart;
    }

    class CursedDartBox : BaseAmmo
    {
        public override int AmmunitionItem => ItemID.CursedDart;
    }

    class IchorDartBox : BaseAmmo
    {
        public override int AmmunitionItem => ItemID.IchorDart;
    }

    class PoisonDartBox : BaseAmmo
    {
        public override int AmmunitionItem => ItemID.PoisonDart;
    }
}
