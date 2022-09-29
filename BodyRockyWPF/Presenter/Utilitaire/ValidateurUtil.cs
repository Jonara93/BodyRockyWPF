﻿using BodyRockyWPF.Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyRockyWPF.Presenter.Utilitaire
{
    public static class ValidateurUtil
    {
        public static bool IsTypeCategorieValidEtPasExistant(TypeProduit tp, List<TypeProduit> listTp)
        {
            return tp != null && listTp != null && tp.Intitule != null && tp.Intitule.Length >= 4 && !listTp.Contains(tp);
        }
    }
}