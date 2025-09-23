using System;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;

namespace Common
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AsBuilder(this string self)
        {
            return new StringBuilder(self);
        }

        public static StringBuilder AppendNewLine(this StringBuilder self)
        {
            self.Append(Environment.NewLine);
            return self;
        }

        public static StringBuilder RichAlign(this StringBuilder self, string alignment)
        {
            self.Insert(0, "\">");
            self.Insert(0, alignment);
            self.Insert(0, "<align=\"");
            self.Append("</align>");
            return self;
        }

        public static StringBuilder RichAlpha(this StringBuilder self, string alpha)
        {
            self.Insert(0, '>');
            self.Insert(0, alpha);
            self.Insert(0, "<alpha=");
            self.Append("</alpha>");
            return self;
        }

        public static StringBuilder RichBold(this StringBuilder self)
        {
            self.Insert(0, "<b>");
            self.Append("</b");
            return self;
        }

        public static StringBuilder RichBreakPrefix(this StringBuilder self)
        {
            self.Insert(0, "<br>");
            return self;
        }

        public static StringBuilder RichBreakSuffix(this StringBuilder self)
        {
            self.Append("<br>");
            return self;
        }

        public static StringBuilder RichColor(this StringBuilder self, string color)
        {
            self.Insert(0, '>');
            self.Insert(0, color);
            self.Insert(0, "<color=");
            self.Append("</color>");
            return self;
        }

        public static StringBuilder RichFont(this StringBuilder self, string font)
        {
            self.Insert(0, "\">");
            self.Insert(0, font);
            self.Insert(0, "<font=\"");
            self.Append("</font>");
            return self;
        }

        public static StringBuilder RichFontWeight(this StringBuilder self, int weight)
        {
            self.Insert(0, "\">");
            self.Insert(0, weight);
            self.Insert(0, "<font-weight=\"");
            self.Append("</font-weight>");
            return self;
        }

        public static StringBuilder RichGradient(this StringBuilder self, string gradient)
        {
            self.Insert(0, "\">");
            self.Insert(0, gradient);
            self.Insert(0, "<gradient=\"");
            self.Append("</gradient>");
            return self;
        }

        public static StringBuilder RichHyperlink(this StringBuilder self, string url)
        {
            self.Insert(0, "\">");
            self.Insert(0, url);
            self.Insert(0, "<a href=\"");
            self.Append("</a>");
            return self;
        }

        public static StringBuilder RichIndent(this StringBuilder self, int percent)
        {
            self.Insert(0, "%>");
            self.Insert(0, percent);
            self.Insert(0, "<indent=");
            self.Append("</indent>");
            return self;
        }

        public static StringBuilder RichItalic(this StringBuilder self)
        {
            self.Insert(0, "<i>");
            self.Append("</i");
            return self;
        }

        public static StringBuilder RichLineHeight(this StringBuilder self, int percent)
        {
            self.Insert(0, "%>");
            self.Insert(0, percent);
            self.Insert(0, "<line-height=");
            self.Append("</line-height>");
            return self;
        }

        public static StringBuilder RichLineIndent(this StringBuilder self, int percent)
        {
            self.Insert(0, "%>");
            self.Insert(0, percent);
            self.Insert(0, "<line-indent=");
            self.Append("</line-indent>");
            return self;
        }

        public static StringBuilder RichLink(this StringBuilder self, string id)
        {
            self.Insert(0, "\">");
            self.Insert(0, id);
            self.Insert(0, "<link=\"");
            self.Append("</link>");
            return self;
        }

        public static StringBuilder RichLowercase(this StringBuilder self)
        {
            self.Insert(0, "<lowercase>");
            self.Append("</lowercase");
            return self;
        }

        public static StringBuilder RichMargin(this StringBuilder self, int margin)
        {
            self.Insert(0, "em>");
            self.Insert(0, margin);
            self.Insert(0, "<margin=");
            self.Append("</margin>");
            return self;
        }

        public static StringBuilder RichMarginLeft(this StringBuilder self, int margin)
        {
            self.Insert(0, "em>");
            self.Insert(0, margin);
            self.Insert(0, "<margin-left=");
            self.Append("</margin-left>");
            return self;
        }

        public static StringBuilder RichMarginRight(this StringBuilder self, int margin)
        {
            self.Insert(0, "em>");
            self.Insert(0, margin);
            self.Insert(0, "<margin-right=");
            self.Append("</margin-right>");
            return self;
        }

        public static StringBuilder RichMark(this StringBuilder self, string mark)
        {
            self.Insert(0, '>');
            self.Insert(0, mark);
            self.Insert(0, "<mark=");
            self.Append("</mark>");
            return self;
        }

        public static StringBuilder RichMonospace(this StringBuilder self, float monospace)
        {
            self.Insert(0, "em>");
            self.Insert(0, monospace);
            self.Insert(0, "<mspace=");
            self.Append("</mspace>");
            return self;
        }

        public static StringBuilder RichNoBreak(this StringBuilder self)
        {
            self.Insert(0, "<nobr>");
            self.Append("</nobr");
            return self;
        }

        public static StringBuilder RichNoParse(this StringBuilder self)
        {
            self.Insert(0, "<noparse>");
            self.Append("</noparse");
            return self;
        }

        public static StringBuilder RichRotate(this StringBuilder self, int angle)
        {
            self.Insert(0, "\">");
            self.Insert(0, angle);
            self.Insert(0, "<rotate=\"");
            self.Append("</rotate>");
            return self;
        }

        public static StringBuilder RichSize(this StringBuilder self, int size)
        {
            self.Insert(0, '>');
            self.Insert(0, size);
            self.Insert(0, "<size=");
            self.Append("</size>");
            return self;
        }

        public static StringBuilder RichSpace(this StringBuilder self, float space)
        {
            self.Insert(0, "em>");
            self.Insert(0, space);
            self.Insert(0, "<space=");
            self.Append("</space>");
            return self;
        }

        public static StringBuilder RichSpritePrefix(this StringBuilder self, string spritename)
        {
            self.Insert(0, "\">");
            self.Insert(0, spritename);
            self.Insert(0, "<sprite name=\"");
            return self;
        }

        public static StringBuilder RichSpriteSuffix(this StringBuilder self, string spritename)
        {
            self.Append("<sprite name=\"");
            self.Append(spritename);
            self.Append("\">");
            return self;
        }

        public static StringBuilder RichStrikethrough(this StringBuilder self)
        {
            self.Insert(0, "<s>");
            self.Append("</s");
            return self;
        }

        public static StringBuilder RichStyle(this StringBuilder self, string style)
        {
            self.Insert(0, "\">");
            self.Insert(0, style);
            self.Insert(0, "<style=\"");
            self.Append("</style>");
            return self;
        }

        public static StringBuilder RichUnderline(this StringBuilder self)
        {
            self.Insert(0, "<u>");
            self.Append("</u");
            return self;
        }

        public static StringBuilder RichUppercase(this StringBuilder self)
        {
            self.Insert(0, "<uppercase>");
            self.Append("</uppercase");
            return self;
        }

        public static StringBuilder RichWidth(this StringBuilder self, int percent)
        {
            self.Insert(0, "%>");
            self.Insert(0, percent);
            self.Insert(0, "<width=");
            self.Append("</width>");
            return self;
        }
    }
}
