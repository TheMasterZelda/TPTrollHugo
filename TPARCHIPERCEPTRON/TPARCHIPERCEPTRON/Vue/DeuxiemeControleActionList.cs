using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace TPARCHIPERCEPTRON.Vue
{
    public class DeuxiemeControleActionList : DesignerActionList
    {
        public DeuxiemeControleActionList(IComponent component) : base(component)
        {
        }

        // Liste des propriétés à ajouter au SmartTag
        public string FichierEntrainement
        {
            get { return ((ucDeuxiemeControle)this.Component).FichierEntrainement; }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["FichierEntrainement"];
                property.SetValue(this.Component, value);
            }
        }

        public bool ModePhrase
        {
            get { return ((ucDeuxiemeControle)this.Component).ModePhrase; }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["ModePhrase"];
                property.SetValue(this.Component, value);
            }
        }

        public double CstApprentissage
        {
            get { return ((ucDeuxiemeControle)this.Component).CstApprentissage; }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["CstApprentissage"];
                property.SetValue(this.Component, value);
            }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Paramétrage"));
            items.Add(new DesignerActionPropertyItem("FichierEntrainement", "Définissez le titre du groupe de contrôles: "));
            items.Add(new DesignerActionPropertyItem("ModePhrase", "Définissez le nom d'utilisateur par défaut: "));
            items.Add(new DesignerActionPropertyItem("CstApprentissage", "Définissez mot de passe par défaut: "));

            return items;
        }
    }
}
