using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.ExceptionHandling
{
    public interface ILocalizeErrorMessage
    {
        string LocalizeMessage(LocalizationContext context);
    }
}
