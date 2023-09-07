using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfTestUI
{
    public  class UCTestableStatus<TStatus> : UserControl, IUCTestableStatus<TStatus> where TStatus : System.Enum
    {
        public UCTestableStatus()
        {

        }

        public static readonly DependencyProperty UIStatusProperty =
            DependencyProperty.Register("UIStatusLabel", typeof(TStatus), typeof(UCTestableStatus<TStatus>));

        public static readonly DependencyProperty UIStatusStringProperty =
            DependencyProperty.Register("UIStatusString", typeof(string), typeof(UCTestableStatus<TStatus>));


        public TStatus UIStatusLabel
        {
            get { return (TStatus)this.GetValue(UIStatusProperty); }
            set
            {
                this.SetValue(UIStatusProperty, value);
                this.SetValue(UIStatusStringProperty, value.ToString());
                SetStatus(value);

            }
        }

        public string? UIStatusString
        {
            get { return this.GetValue(UIStatusStringProperty).ToString(); }
        }

        public virtual void SetStatus(TStatus status)
        {

        }


    }
}
