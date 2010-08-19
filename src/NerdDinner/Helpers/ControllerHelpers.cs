using System.Collections.Generic;
using System.Web.Mvc;
using NerdDinner.Models;

namespace NerdDinner.Helpers
{
    public static class ModelStateHelpers
    {
        public static void AddModelErrors(this ModelStateDictionary modelState, IEnumerable<RuleViolation> errors)
        {
            foreach (var issue in errors)
            {
                modelState.AddModelError(issue.PropertyName, issue.ErrorMessage);
            }
        }
    }
}