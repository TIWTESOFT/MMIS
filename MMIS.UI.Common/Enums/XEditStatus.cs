using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.UI.Common
{
    public enum XEditStatus
    {
        None = 0,
        AddNew = 1,
        Edit = 2,
        Delete = 3,
        Copy = 4,
        AddContinue = 5,
        Commit = 6,
        Rollback = 7,
        Check = 8,
        BackCheck = 9,
        Send = 10,
        BackSend = 11,
        Feedback = 12,
        BackFeedback = 13
    }
}
