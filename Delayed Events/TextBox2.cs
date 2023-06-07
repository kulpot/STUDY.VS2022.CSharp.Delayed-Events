using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delayed_Events
{
    class TextBox2 : TextBox
    {
        private Timer _timer = new Timer();
        public event EventHandler TextChangedDelayed;

        public TextBox2()
        {
            _timer.Interval = 500;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            OnTextChangedDelayed();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _timer.Stop(); // reset cause of start default 
            _timer.Start();
        }

        protected virtual void OnTextChangedDelayed()
        {
            if(TextChangedDelayed != null)
            {
                TextChangedDelayed(this, EventArgs.Empty);
            }
        }

        public int TextChangedDelayedInterval
        {
            get { return _timer.Interval; }
            set { _timer.Interval = value; }
        }
    }
}
