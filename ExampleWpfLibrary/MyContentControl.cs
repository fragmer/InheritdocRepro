using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace ExampleWpfLibrary
{
    /// <summary>
    /// Example of a WPF control with inheritdoc.
    /// </summary>
    public class MyContentControl : ContentControl
    {
        /// <inheritdoc />
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        /// <inheritdoc cref="System.Windows.UIElement.OnCreateAutomationPeer" />
        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return base.OnCreateAutomationPeer();
        }
    }
}
