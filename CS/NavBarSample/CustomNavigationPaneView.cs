using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.NavBar;

namespace NavBarSample {
    public class CustomNavigationPaneView : NavigationPaneView {
        public double OpenedWidth { get; set; }
        public double PreviousWidth { get; set; }
        protected override void UpdatePresenterTemplateByEnabledState() {
            if (OpenedWidth != 0) {
                ExpandedWidth = OpenedWidth;
            }
            base.UpdatePresenterTemplateByEnabledState();
        }       
    }
}
