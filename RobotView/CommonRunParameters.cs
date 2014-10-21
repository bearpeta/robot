//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: CommonRunParameters.cs 828 2012-08-05 09:10:38Z zajost $
//------------------------------------------------------------------------------
#define VARIANTE2
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.RobotView
{
    public partial class CommonRunParameters : UserControl
    {


#if VARIANTE1

        #region events
        public event EventHandler<EventArgs> SpeedChanged;
        public event EventHandler<EventArgs> AccelerationChanged;
        #endregion


        #region constructor & destructor
        public CommonRunParameters()
        {
            InitializeComponent();
            upDownAcceleration.ValueChanged += new EventHandler(upDownAcceleration_ValueChanged);
            upDownSpeed.ValueChanged += new EventHandler(upDownSpeed_ValueChanged);
        }
        #endregion


        #region properties
        public float Speed
        {
            get { return (float)upDownSpeed.Value / 1000; }
            set { upDownSpeed.Value = (decimal)value * 1000; }
        }

        public float Acceleration
        {
            get { return (float)upDownAcceleration.Value / 1000; }
            set { upDownAcceleration.Value = (decimal)value * 1000; }
        }
        #endregion


        #region methods
        void upDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (SpeedChanged != null)
            {
                SpeedChanged(this, e);
            }
        }

        void upDownAcceleration_ValueChanged(object sender, EventArgs e)
        {
            if (AccelerationChanged != null)
            {
                AccelerationChanged(this, e);
            }
        }
        #endregion

#else

        #region constructor & destructor
        public CommonRunParameters()
        {
            InitializeComponent();
        }
        #endregion


        #region properties
        public float Speed
        {
            get { return (float)upDownSpeed.Value / 1000; }
            set { upDownSpeed.Value = (decimal)value * 1000; }
        }

        public float Acceleration
        {
            get { return (float)upDownAcceleration.Value / 1000; }
            set { upDownAcceleration.Value = (decimal)value * 1000; }
        }
        #endregion


        #region events
        public event EventHandler SpeedChanged
        {
            add { upDownSpeed.ValueChanged += value; }
            remove { upDownSpeed.ValueChanged -= value; }
        }

        public event EventHandler AccelerationChanged
        {
            add { upDownAcceleration.ValueChanged += value; }
            remove { upDownAcceleration.ValueChanged -= value; }
        }
        #endregion
#endif
    }
}
