using Orchard;

namespace Bootstrap {
    public static class ThemeHelper {

        /// <summary>
        /// Retrieves settings for the theme from Orchard's WorkContext.
        /// </summary>
        /// <param name="workContext">The WorkContext to retrieve the settings from.</param>
        /// <param name="itemName">The setting name to retrieve.</param>
        /// <returns>A boolean representing the current Theme Setting.</returns>
        public static bool SettingsEval(this WorkContext workContext, string itemName) {
            var returnValue = false;
            var context = workContext.HttpContext;
            if (context.Items[itemName] != null && (string) context.Items[itemName] == bool.TrueString) {
                returnValue = true;
            }
            return returnValue;
        }

        /// <summary>
        /// Returns the correct Bootstrap CSS class for the current Aside Zone configuration.
        /// </summary>
        /// <param name="asideClass">The current Aside Zone configuration.</param>
        /// <returns>A string representing the correct Boostrap CSS class for the zone configuration.</returns>
        public static string GetAsideCssClass(string asideClass) {
            switch (asideClass) {
                case "aside-1": case "aside-2":
                    return "span9";
                case  "aside-12":
                    return "span6";
                default:
                    return "span12";
            }
        }

        /// <summary>
        /// Returns the correct Bootstrap CSS class for the current Triple Zone configuration.
        /// </summary>
        /// <param name="tripleClass">The current Triple Zone configuration.</param>
        /// <returns>A string representing the correct Boostrap CSS class for the zone configuration.</returns>
        public static string GetTripleCssClass(string tripleClass) {
            switch (tripleClass) {
                case "triple-12": case "triple-23": case "triple-13":
                    return "span6";
                case "triple-123":
                    return "span4";
                default:
                    return "span12";
            }
        }

        /// <summary>
        /// Returns the correct Bootstrap CSS class for the current FooterQuad Zone configuration.
        /// </summary>
        /// <param name="footerQuadClass">The current FooterQuad Zone configuration.</param>
        /// <returns>A string representing the correct Boostrap CSS class for the zone configuration.</returns>
        public static string GetFooterQuadCssClass(string footerQuadClass)
        {
            switch (footerQuadClass)
            {
                case "split-12": case "split-13": case "split-14": case "split-23": case "split-24": case "split-34":
                    return "span6";
                case "split-123": case "split-124": case "split-134": case "split-234":
                    return "span4";
                case "split-1234":
                    return "span3";
                default:
                    return "span12";
            }
        }

    }
}