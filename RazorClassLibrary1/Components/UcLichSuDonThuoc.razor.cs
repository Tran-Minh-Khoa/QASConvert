
using Microsoft.AspNetCore.Components;

namespace RazorClassLibrary1.Components
{
    public partial class UcLichSuDonThuoc
    {
        [Parameter]
        public string CategoryName { get; set; }
        [Parameter]
        public bool Enabled { get; set; } = true;
    }
}
