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

        public PremierControleActionList(IComponent component) : base(component)
        {
        }

        public string NomFichierEntrainement
        {
            get
            {
                return ((ucPremierControle)this.Component).NomFichierEntrainement;
            }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["NomFichierEntrainement"];
                property.SetValue(this.Component, value);
            }
        }

        public string EmplacementFichierEntrainement
        {
            get
            {
                return ((ucPremierControle)this.Component).EmplacementFichierEntrainement;
            }

            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["EmplacementFichierEntrainement"];
                property.SetValue(this.Component, value);
            }
        }

        public bool NouveauFichier
        {
            get
            {
                return ((ucPremierControle)this.Component).NouveauFichier;
            }

            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["NouveauFichier"];
                property.SetValue(this.Component, value);
            }
        }

        public double ConstanteApprentissage
        {
            get
            {
                return ((ucPremierControle)this.Component).ConstanteApprentissage;
            }

            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["ConstanteApprentissage"];
                property.SetValue(this.Component, value);
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
