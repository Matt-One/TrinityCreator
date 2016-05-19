﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCreator;

namespace TrinityCreator.CreatureTemplates
{
    class ClassTrainerTemplate : TrainerTemplate
    {
        public ClassTrainerTemplate() : base() { }

        public override void LoadTemplate()
        {
            SetBmspValues(NpcFlags, new int[] { 32 });      // Class Trainer
            SetIKVPValue(Page.trainerCb, 3);                // Any class
            base.LoadTemplate();
        }
    }
}