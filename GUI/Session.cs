using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class Session
    {
        public static AccountDTO CurrentUser { get; set; }
        public static event Action OnPermissionChanged;
        public static void TriggerPermissionChange()
        {
            OnPermissionChanged?.Invoke();
        }
    }
}
