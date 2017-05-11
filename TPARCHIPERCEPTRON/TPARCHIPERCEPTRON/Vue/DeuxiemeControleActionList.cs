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
        public string TextGrpDessin
        {
            get { return ((ucDeuxiemeControle)this.Component).TextGrpDessin; }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["TextGrpDessin"];
                property.SetValue(this.Component, value);
            }
        }
        public string ResultText
        {
            get { return ((ucDeuxiemeControle)this.Component).ResultText; }
            set
            {
                PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)["ResultText"];
                property.SetValue(this.Component, value);
            }
        }

        [Browsable(false)]
        public ucZoneDessin ZoneDessin
        {
            get { return ((ucDeuxiemeControle)this.Component).ZoneDessin; }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Paramétrage"));
            items.Add(new DesignerActionPropertyItem("TextGrpDessin", "Définissez le titre du groupe de contrôles: "));
            items.Add(new DesignerActionPropertyItem("ResultText", "Définissez le nom d'utilisateur par défaut: "));
            items.Add(new DesignerActionPropertyItem("ZoneDessin", "Définissez mot de passe par défaut: "));

            return items;
        }
    }
}
