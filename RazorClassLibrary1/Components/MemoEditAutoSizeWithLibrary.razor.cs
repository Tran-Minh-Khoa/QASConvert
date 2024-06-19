using System;
using System.Drawing;
using DevExpress.Blazor;
using DevExpress.Utils.CommonDialogs.Internal;
using Microsoft.AspNetCore.Components;
//using QA.Shared.Practice;
namespace RazorClassLibrary1.Components
{
    public partial class MemoEditAutoSizeWithLibrary : ComponentBase
    {
        //[Inject]
        //public QA.IClientServices Services { get; set; }

        [Parameter]
        public string CategoryName { get; set; }

        //[Parameter]
        //public string Delimiter { get; set; } = " ";

        //[Parameter]
        //public int HeightDefault { get; set; } = 26;

        //[Parameter]
        //public bool AutoSize { get; set; } = true;

        //[Parameter]
        //public int MaxLength { get; set; } = 0;

        //[Parameter]
        //public string Text { get; set; }

        [Parameter]
        public bool Enabled { get; set; } = true;

        ////private frmMemoTemplate _memoTemplate;

        //private int _height;

        //protected override void OnInitialized()
        //{
        //    if (AutoSize)
        //    {
        //        _height = HeightDefault;
        //    }
        //    else
        //    {
        //        _height = int.MaxValue;
        //    }
        //}

        //private void OnTextChanged(string newText)
        //{
        //    if (AutoSize)
        //    {
        //        _height = Math.Max(HeightDefault, MeasureTextHeight(newText) + 6);
        //    }
        //}

        ////private void OnEditValueChanging(object sender, DevExpress.Blazor.ChangingEventArgs<string> e)
        ////{
        ////	if (MaxLength > 0 && e.NewValue != null && e.NewValue.Length > MaxLength)
        ////	{
        ////		QA.UI.ShowWarning("Vượt quá ký tự cho phép!");
        ////		e.Cancel = true;
        ////	}
        ////}

        //private void ShowMemoTemplate()
        //{
        //    //if (_memoTemplate == null || _memoTemplate.IsDisposed)
        //    //{
        //    //	_memoTemplate = new frmMemoTemplate();
        //    //	_memoTemplate.Initialize(Services);
        //    //	_memoTemplate.CategoryName = CategoryName;
        //    //	_memoTemplate.Process();
        //    //	if (_memoTemplate.ShowDialog() == DialogResult.OK)
        //    //	{
        //    //		var value = _memoTemplate.Value;
        //    //		if (!string.IsNullOrEmpty(value))
        //    //		{
        //    //			if (string.IsNullOrEmpty(Text))
        //    //			{
        //    //				Text = value;
        //    //			}
        //    //			else
        //    //			{
        //    //				Text = $"{Text}{Delimiter}{value}";
        //    //			}
        //    //		}
        //    //	}
        //    //}
        //    //else
        //    //{
        //    //	_memoTemplate.CategoryName = CategoryName;
        //    //	_memoTemplate.Initialize(Services);
        //    //	_memoTemplate.Process();
        //    //	if (_memoTemplate.ShowDialog() == DialogResult.OK)
        //    //	{
        //    //		var value = _memoTemplate.Value;
        //    //		if (!string.IsNullOrEmpty(value))
        //    //		{
        //    //			if (string.IsNullOrEmpty(Text))
        //    //			{
        //    //				Text = value;
        //    //			}
        //    //			else
        //    //			{
        //    //				Text = $"{Text}{Delimiter}{value}";
        //    //			}
        //    //		}
        //    //	}
        //    //}
        //}

        //private int MeasureTextHeight(string text)
        //{
        //    using (var g = Graphics.FromHwnd(IntPtr.Zero))
        //    {
        //        var stringSize = g.MeasureString(text, new Font("Segoe UI", 14, FontStyle.Regular));
        //        return (int)stringSize.Height;
        //    }
        //}
    }
}
