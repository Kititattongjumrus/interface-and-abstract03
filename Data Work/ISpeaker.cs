using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptForUser
{
    internal interface ISpeaker
    {
        void Train();
        void Approve(User trainee);
    }
}