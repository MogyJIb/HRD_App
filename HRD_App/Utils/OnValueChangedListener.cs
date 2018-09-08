using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Utils
{
    public interface OnValueChangedListener<T>
    {
        void onValueChanged(T value);
    }
}
