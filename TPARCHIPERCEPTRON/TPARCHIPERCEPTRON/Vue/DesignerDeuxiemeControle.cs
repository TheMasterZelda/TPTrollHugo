using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;

namespace TPARCHIPERCEPTRON.Vue
{
    public class DesignerDeuxiemeControle : System.Windows.Forms.Design.ControlDesigner
    {
        // On définit la liste des actions du SmartTag
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionListCollection collectionAction = new DesignerActionListCollection();
                DeuxiemeControleActionList designerActionList = new DeuxiemeControleActionList(this.Control);
                collectionAction.Add(designerActionList);

                return collectionAction;
            }
        }
    }
}
