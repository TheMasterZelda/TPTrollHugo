using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace TPARCHIPERCEPTRON.Vue
{
    public class PremierControleActionList : DesignerActionList
    {
        private string _NomFichierEntrainement;
        private string _EmplacementFichierEntrainement;
        private bool _NouveauFichier;
        private float _ConstanteApprentissage;
        public PremierControleActionList(IComponent component) : base(component)
        {
        }

        public string NomFichierEntrainement
        {
            get
            {
                return _NomFichierEntrainement;
            }
            set
            {
                _NomFichierEntrainement = value;
            }
        }

        public string EmplacementFichierEntrainement
        {
            get
            {
                return _EmplacementFichierEntrainement;
            }

            set
            {
                _EmplacementFichierEntrainement = value;
            }
        }

        public bool NouveauFichier
        {
            get
            {
                return _NouveauFichier;
            }

            set
            {
                _NouveauFichier = value;
            }
        }

        public float ConstanteApprentissage
        {
            get
            {
                return _ConstanteApprentissage;
            }

            set
            {
                _ConstanteApprentissage = value;
            }
        }

        public ucZoneDessin ZoneDessin
        {
            get
            {
                return ZoneDessin;
            }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Paramétrage"));
            items.Add(new DesignerActionPropertyItem("NomFichierEntrainement", "Définissez le nom du fichier d'entrainement"));
            items.Add(new DesignerActionPropertyItem("EmplacementFichierEntrainement", "Définissez l'emplacement du fichier d'entrainement"));
            items.Add(new DesignerActionPropertyItem("NouveauFichier", "Définissez si on utilise ou non un nouveau fichier"));
            items.Add(new DesignerActionPropertyItem("ConstanteApprentissage", "Définissez la constante d'apprentissage"));
            items.Add(new DesignerActionPropertyItem("ZoneDessin", "Zone de dessin"));

            return items;
        }
    }
}
