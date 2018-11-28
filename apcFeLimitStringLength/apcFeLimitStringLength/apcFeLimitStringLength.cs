using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P21.Extensions.BusinessRule;

namespace apc
{
    public class apcFeLimitStringLength : Rule
    {
        public override RuleResult Execute()
        {
            RuleResult result = new RuleResult();

            try
            {
                string targetValue = Data.Fields.GetFieldByAlias("TARGET").FieldValue;
                int maxCharLimit = 40;

                if (targetValue.Length > maxCharLimit)
                {
                    result.Message = "The Field Cannot Exceed 40 Characters.";
                    result.Success = false;
                }
                else
                {
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }


        //required class to give a name to the class
        public override string GetName()
        {
            return "apcFeLimitStringLength";
        }

        //requried class to provide a short description
        public override string GetDescription()
        {
            return "CHARACTER LIMIT: Warns User if the character limit exceeds.";
        }

    }
}
