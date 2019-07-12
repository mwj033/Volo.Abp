using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Volo.Abp.Localization
{
    public static class AbpCultureHelper
    {
        public static IDisposable Use([NotNull] string culture, string uiCulture = null)
        {
            Check.NotNull(culture, nameof(culture));

            return Use(new CultureInfo(culture), uiCulture == null ? null : new CultureInfo(uiCulture));
        }

        public static IDisposable Use([NotNull] CultureInfo culture, CultureInfo uiCulture = null)
        {
            Check.NotNull(culture, nameof(culture));

            var currentCulture = CultureInfo.CurrentCulture;
            var currentUiCulture = CultureInfo.CurrentUICulture;

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = uiCulture ?? culture;

            return new DisposeAction(()=> 
            {
                CultureInfo.CurrentCulture = currentCulture;
                CultureInfo.CurrentUICulture = currentUiCulture;
            });
        }
    }
}
