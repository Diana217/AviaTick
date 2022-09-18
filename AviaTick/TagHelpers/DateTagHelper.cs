using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AviaTick.TagHelpers
{
    public class DateTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            output.TagName = "div";
            output.Content.SetContent($"Current date: {DateTime.Now.ToString("dd/mm/yyyy")}");
        }
    }

    public class TimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            output.TagName = "div";
            output.Content.SetContent($"Current time: {DateTime.Now.ToString("HH:mm:ss")}");
        }
    }

    public class SummaryTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var target = await output.GetChildContentAsync();
            var content = target.GetContent();
            output.Content.SetHtmlContent(content);
            //return base.ProcessAsync(context, output);
        }
    }
}
