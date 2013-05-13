/// Author:         Anthony Baker   
/// Date:           May 5th, 2013
/// Class:          MainPage
/// Description:    Controls the clipping mask animation based on the 
///                 ScrollViewer control Manipulation Delta event.

using Microsoft.Phone.Controls;

namespace ClippingMaskSample_03
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnManipulationDelta(object sender, System.Windows.Input.ManipulationDeltaEventArgs e)
        {
            var manipulation = e.DeltaManipulation;
            MaskTransform.Y += manipulation.Translation.Y;

            // Display debug info
            this.DebugInfo.Text = string.Format("Offset:{0}, TX:{1}, TY:{2}, SX:{3}, SY{4}, MTY:{5}",
                this.ScrollViewer.VerticalOffset,
                manipulation.Translation.X,
                manipulation.Translation.Y,
                manipulation.Scale.X,
                manipulation.Scale.Y,
                MaskTransform.Y);  
        }
    }
}