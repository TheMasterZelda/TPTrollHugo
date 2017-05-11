using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace TPARCHIPERCEPTRON.Vue
{
    public class DesignerPremierControle : System.Windows.Forms.Design.ControlDesigner
    {
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionListCollection collectionAction = new DesignerActionListCollection();
                PremierControleActionList designerActionList = new PremierControleActionList(this.Control);
                collectionAction.Add(designerActionList);

                return collectionAction;
            }
        }
    }
}
